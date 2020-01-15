using Microsoft.Dynamics.BusinessConnectorNet;
using SupermaskERP.AxBusinessConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.AX
{
    public class ConnectTest
    {

    }
    public class SetOnLineUser
    {
        private const string AXTABLE = "QY_USERONLINE";       //要操作的AX表
        private string m_emplyId = string.Empty;
        private Hashtable m_hsParam = null;
        private string m_ipAddress = string.Empty;

        public SetOnLineUser(string EmplyId)
        {
            m_emplyId = EmplyId;
            m_hsParam = new Hashtable();
        }

        public SetOnLineUser(string EmplyId, string ipAddress)
        {
            m_emplyId = EmplyId;
            m_ipAddress = ipAddress;
            m_hsParam = new Hashtable();
        }

        public bool SaveOnLine()
        {
            bool result = false;

            m_hsParam.Add("EMPLID", "test");
            m_hsParam.Add("ISLOGON", 1);
            m_hsParam.Add("ASSEMBLYVER", "test");
            m_hsParam.Add("LOGONTIME", "test");
            m_hsParam.Add("IPADDRESS", "test");

            AXHelper AX = new AXHelper();
            AX.Create(AXTABLE, m_hsParam);

            return result;
        }
    }

}
namespace SupermaskERP.AxBusinessConnector
{
    //BC无效
    //１：cmd->telnet AOS(名字或IP)　2712(端口) 无异常
    //２：登录到AOS服务器检查是否有登录用户
    //３：将C:\Program Files\Microsoft Dynamics AX\50\Client\Bin里面的dll拖到C:\WINDOWS\assembly里面
    //４：检查配置文件bindir,Text,C:\Program Files\Microsoft Dynamics AX\50\Client\Bin这个路径与实际安
    //装的BC路径是否一致
    //５：将配置文件放到AOS服务器上检查是否能启动AX
    // 6: host文件增加192.105.58.89    axaos    192.105.68.181   admserver.supermask.cn     192.105.68.181   admserver

    public class AXHelper
    {
        public string m_userName = string.Empty;
        public string m_PassWrd = string.Empty;
        public string m_DoMain = string.Empty;
        public NetworkCredential m_nc = null;

        public string MainXPConfig = @"\\192.105.58.81\axerp\WinXP.axc";
        public string MainWin7Config = @"\\192.105.58.81\axerp\Win732.axc";
        public string TestConfig = @"\\192.105.58.81\axerp\AX_TEST.axc";

        public string BakXPConfig = @"\\192.105.58.81\axerp\WinXP.axc";
        public string BakWin7Config = @"\\192.105.58.81\axerp\Win732.axc";

        //public string m_configurationPath = @"C:\Program Files\Microsoft Dynamics AX\50\Client\Bin\AX_ERP.axc";

        public string m_configurationPath = string.Empty;

        //public string m_configurationPath = @"\\192.105.58.81\axerp\CRP.axc";
        public AXHelper()
        {
            m_configurationPath = MainWin7Config;
        }

        public AXHelper(string user, string pwd, string domain)
        {
            m_userName = user;
            m_PassWrd = pwd;
            m_DoMain = domain;
            m_nc = new NetworkCredential(m_userName, m_PassWrd, m_DoMain);
        }

        /// <summary>
        /// Create Method
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="dict">字段值字典</param>
        public bool Create(String tableName, Hashtable hs)
        {
            Boolean ret = false;
            Axapta ax = new Axapta();
            try
            {
                ax.Logon(null, null, null, m_configurationPath);
                //ax.LogonAs(m_userName, m_DoMain, m_nc, null, null, null, m_configurationPath);
                using (AxaptaRecord axRecord = ax.CreateAxaptaRecord(tableName))
                {
                    ax.TTSBegin();
                    axRecord.Clear();
                    axRecord.InitValue();

                    foreach (DictionaryEntry de in hs)
                    {
                        string key = de.Key.ToString();
                        object value = de.Value;
                        axRecord.set_Field(key, value);
                    }
                    if (axRecord.ValidateWrite())
                    {
                        axRecord.Insert();
                        ax.TTSCommit();
                        ret = true;

                    }
                    else
                    {
                        ax.CallStaticClassMethod("IWS_CAMErrorInfo", "throwInfo");
                        ax.TTSAbort();
                    }
                }
                ax.Logoff();
            }
            catch (Exception ex)
            {
                ax.TTSAbort();
                ax.Logoff();
                //throw new Exception(ex.Message);
            }

            return ret;
        }

        /// <summary>
        /// Create Method
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="dict">字段值字典</param>
        public bool Create(String tableName, IDictionary<String, Object> dict)
        {
            Boolean ret = false;
            Axapta ax = new Axapta();
            try
            {
                ax.Logon(null, null, null, m_configurationPath);
                //ax.LogonAs(m_userName, m_DoMain, m_nc, null, null, null, m_configurationPath);
                IEnumerator<KeyValuePair<String, Object>> dem = dict.GetEnumerator();

                using (AxaptaRecord axRecord = ax.CreateAxaptaRecord(tableName))
                {
                    ax.TTSBegin();
                    axRecord.Clear();
                    axRecord.InitValue();

                    while (dem.MoveNext())
                    {
                        String key = dem.Current.Key;
                        Object value = dem.Current.Value;

                        axRecord.set_Field(key, value);
                    }
                    if (axRecord.ValidateWrite())
                    {
                        axRecord.Insert();
                        ax.TTSCommit();
                        ret = true;

                    }
                    else
                    {
                        ax.CallStaticClassMethod("IWS_CAMErrorInfo", "throwInfo");
                        ax.TTSAbort();
                    }
                }
                ax.Logoff();
            }
            catch (Exception ex)
            {
                ax.TTSAbort();
                ax.Logoff();
                ////MessageBox.Show(ex.Message);
                //throw new Exception(ex.Message);
            }

            return ret;
        }

        /// <summary>
        /// Update Method
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="pkey">键名称</param>
        /// <param name="where">条件值</param>
        /// <param name="dict">字段值字典</param>
        public bool Update(String tableName, String pkey, String where, IDictionary<String, Object> dict)
        {
            Boolean ret = false;
            Axapta ax = new Axapta();
            try
            {
                ax.Logon(null, null, null, m_configurationPath);
                //ax.LogonAs(m_userName, m_DoMain, m_nc, null, null, null, m_configurationPath);
                IEnumerator<KeyValuePair<String, Object>> dem = dict.GetEnumerator();

                using (AxaptaRecord axRecord = ax.CreateAxaptaRecord(tableName))
                {
                    ax.TTSBegin();

                    String sql = String.Format("select forupdate * from %1 where %1.{0} == '{1}'", pkey, where);
                    axRecord.ExecuteStmt(sql);

                    do
                    {
                        if (axRecord.Found)
                        {
                            while (dem.MoveNext())
                            {
                                String key = dem.Current.Key;
                                Object value = dem.Current.Value;

                                axRecord.set_Field(key, value);
                            }
                            if (axRecord.ValidateWrite())
                            {
                                axRecord.Update();
                                ret = true;

                            }
                            else
                            {
                                ax.CallStaticClassMethod("IWS_CAMErrorInfo", "throwInfo");
                                ret = false;
                                ax.TTSAbort();
                            }
                        }
                    } while (axRecord.Next());
                    ax.TTSCommit();
                }
                ax.Logoff();
            }
            catch (Exception ex)
            {
                ax.Logoff();
                //MessageBox.Show(ex.Message);
                //throw new Exception(ex.Message);
            }

            return ret;
        }

        public bool Update(String tableName, String where, IDictionary<String, Object> dict)
        {
            Boolean ret = false;
            Axapta ax = new Axapta();
            try
            {
                ax.Logon(null, null, null, m_configurationPath);
                //ax.LogonAs(m_userName, m_DoMain, m_nc, null, null, null, m_configurationPath);
                IEnumerator<KeyValuePair<String, Object>> dem = dict.GetEnumerator();

                using (AxaptaRecord axRecord = ax.CreateAxaptaRecord(tableName))
                {
                    ax.TTSBegin();
                    String sql = String.Format("select forupdate * from %1 where {0}", where);
                    axRecord.ExecuteStmt(sql);

                    do
                    {
                        if (axRecord.Found)
                        {
                            while (dem.MoveNext())
                            {
                                String key = dem.Current.Key;
                                Object value = dem.Current.Value;
                                axRecord.set_Field(key, value);
                            }
                            if (axRecord.ValidateWrite())
                            {
                                axRecord.Update();
                                ret = true;

                            }
                            else
                            {
                                ax.CallStaticClassMethod("IWS_CAMErrorInfo", "throwInfo");
                                ret = false;
                                ax.TTSAbort();
                            }
                        }
                    } while (axRecord.Next());
                    ax.TTSCommit();
                }
                ax.Logoff();
            }
            catch (Exception ex)
            {
                ax.TTSAbort();
                ax.Logoff();
                //MessageBox.Show(ex.Message);
                //throw new Exception(ex.Message);
            }

            return ret;
        }


        /// <summary>
        /// Update Method
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="pkey">键名称</param>
        /// <param name="where">条件值</param>
        /// <param name="dict">字段值字典</param>
        public bool Update(String tableName, String pkey, String where, Hashtable hs)
        {
            Boolean ret = false;
            Axapta ax = new Axapta();
            try
            {
                ax.Logon(null, null, null, m_configurationPath);
                //ax.LogonAs(m_userName, m_DoMain, m_nc, null, null, null, m_configurationPath);
                using (AxaptaRecord axRecord = ax.CreateAxaptaRecord(tableName))
                {
                    ax.TTSBegin();

                    String sql = String.Format("select forupdate * from %1 where %1.{0} == '{1}'", pkey, where);
                    axRecord.ExecuteStmt(sql);

                    do
                    {
                        if (axRecord.Found)
                        {
                            foreach (DictionaryEntry de in hs)
                            {
                                string key = de.Key.ToString();
                                object value = de.Value;
                                axRecord.set_Field(key, value);
                            }
                            if (axRecord.ValidateWrite())
                            {
                                axRecord.Update();
                                ret = true;

                            }
                            else
                            {
                                ret = false;
                                ax.CallStaticClassMethod("IWS_CAMErrorInfo", "throwInfo");
                                ax.TTSAbort();
                            }
                        }
                    } while (axRecord.Next());
                    ax.TTSCommit();
                }
                ax.Logoff();
            }
            catch (Exception ex)
            {
                ax.Logoff();
                //MessageBox.Show(ex.Message);
                //throw new Exception(ex.Message);
            }

            return ret;
        }

        public bool Update(String tableName, String where, Hashtable hs, ref string error)
        {
            Boolean ret = false;
            Axapta ax = new Axapta();
            try
            {
                ax.Logon(null, null, null, m_configurationPath);
                //ax.LogonAs(m_userName, m_DoMain, m_nc, null, null, null, m_configurationPath);
                using (AxaptaRecord axRecord = ax.CreateAxaptaRecord(tableName))
                {
                    ax.TTSBegin();
                    String sql = String.Format("select forupdate * from %1 where {0}", where);
                    axRecord.ExecuteStmt(sql);

                    do
                    {
                        if (axRecord.Found)
                        {
                            foreach (DictionaryEntry de in hs)
                            {
                                string key = de.Key.ToString();
                                object value = de.Value;
                                axRecord.set_Field(key, value);
                            }
                            if (axRecord.ValidateWrite())
                            {
                                axRecord.Update();
                                ret = true;
                            }
                            else
                            {
                                ret = false;
                                ax.CallStaticClassMethod("IWS_CAMErrorInfo", "throwInfo");
                                ax.TTSAbort();
                            }
                        }
                    } while (axRecord.Next());
                    ax.TTSCommit();
                }
                ax.Logoff();
            }
            catch (Exception ex)
            {
                ax.TTSAbort();
                ax.Logoff();
                error += ex.Message + "\r";
                //MessageBox.Show(error + ":" + ex.Message);
                //throw new Exception(ex.Message);
            }

            return ret;
        }

        public bool Update(String tableName, String[] pkeys, Object[] wheres, Hashtable hs)
        {
            Boolean ret = false;
            Axapta ax = new Axapta();
            try
            {
                ax.Logon(null, null, null, m_configurationPath);
                //ax.LogonAs(m_userName, m_DoMain, m_nc, null, null, null, m_configurationPath);
                using (AxaptaRecord axRecord = ax.CreateAxaptaRecord(tableName))
                {
                    ax.TTSBegin();

                    String sql = string.Empty;
                    for (int i = 0; i < pkeys.Length; ++i)
                    {
                        if (i == 0)
                        {
                            if (typeof(String).Equals(wheres[i].GetType()))
                                sql = String.Format("select forupdate * from %1 where %1.{0} == '{1}'", pkeys[i], wheres[i]);
                            else
                                sql = String.Format("select forupdate * from %1 where %1.{0} == {1}", pkeys[i], wheres[i]);
                        }
                        else
                        {
                            if (typeof(String).Equals(wheres[i].GetType()))
                                sql += String.Format(" && %1.{0} == '{1}'", pkeys[i], wheres[i]);
                            else
                                sql += String.Format(" && %1.{0} == {1}", pkeys[i], wheres[i]);

                        }
                    }
                    axRecord.ExecuteStmt(sql);

                    do
                    {
                        if (axRecord.Found)
                        {
                            foreach (DictionaryEntry de in hs)
                            {
                                string key = de.Key.ToString();
                                object value = de.Value;
                                axRecord.set_Field(key, value);
                            }
                            if (axRecord.ValidateWrite())
                            {
                                axRecord.Update();
                                ret = true;

                            }
                            else
                            {
                                ret = false;
                                ax.CallStaticClassMethod("IWS_CAMErrorInfo", "throwInfo");
                                ax.TTSAbort();
                            }
                        }
                    } while (axRecord.Next());
                    ax.TTSCommit();
                }
                ax.Logoff();
            }
            catch (Exception ex)
            {
                ax.Logoff();
                //MessageBox.Show(ex.Message);
                //throw new Exception(ex.Message);
            }

            return ret;
        }

        public bool Update(String tableName, String[] pkeys, Object[] wheres, IDictionary<String, Object> dict)
        {
            Boolean ret = false;
            Axapta ax = new Axapta();
            try
            {
                ax.Logon(null, null, null, m_configurationPath);
                //ax.LogonAs(m_userName, m_DoMain, m_nc, null, null, null, m_configurationPath);
                IEnumerator<KeyValuePair<String, Object>> dem = dict.GetEnumerator();
                using (AxaptaRecord axRecord = ax.CreateAxaptaRecord(tableName))
                {
                    ax.TTSBegin();

                    String sql = string.Empty;
                    for (int i = 0; i < pkeys.Length; ++i)
                    {
                        if (i == 0)
                        {
                            if (typeof(String).Equals(wheres[i].GetType()))
                                sql = String.Format("select forupdate * from %1 where %1.{0} == '{1}'", pkeys[i], wheres[i]);
                            else
                                sql = String.Format("select forupdate * from %1 where %1.{0} == {1}", pkeys[i], wheres[i]);
                        }
                        else
                        {
                            if (typeof(String).Equals(wheres[i].GetType()))
                                sql += String.Format(" && %1.{0} == '{1}'", pkeys[i], wheres[i]);
                            else
                                sql += String.Format(" && %1.{0} == {1}", pkeys[i], wheres[i]);

                        }
                    }
                    axRecord.ExecuteStmt(sql);

                    do
                    {
                        if (axRecord.Found)
                        {
                            while (dem.MoveNext())
                            {
                                String key = dem.Current.Key;
                                Object value = dem.Current.Value;

                                axRecord.set_Field(key, value);
                            }
                            if (axRecord.ValidateWrite())
                            {
                                axRecord.Update();
                                ret = true;

                            }
                            else
                            {
                                ret = false;
                                ax.CallStaticClassMethod("IWS_CAMErrorInfo", "throwInfo");
                                ax.TTSAbort();
                            }
                        }
                    } while (axRecord.Next());
                    ax.TTSCommit();
                }
                ax.Logoff();
            }
            catch (Exception ex)
            {
                ax.Logoff();
                //MessageBox.Show(ex.Message);
                //throw new Exception(ex.Message);
            }

            return ret;
        }

        /// <summary>
        /// Delete Method
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="pkey">键名称</param>
        /// <param name="where">条件值</param>
        /// <param name="dict">字段值字典</param>
        public bool Delete(String tableName, String pkey, String where)
        {
            Boolean ret = false;
            Axapta ax = new Axapta();
            try
            {
                ax.Logon(null, null, null, m_configurationPath);
                //ax.LogonAs(m_userName, m_DoMain, m_nc, null, null, null, m_configurationPath);
                using (AxaptaRecord axRecord = ax.CreateAxaptaRecord(tableName))
                {
                    ax.TTSBegin();

                    String sql = String.Format("select forupdate * from %1 where %1.{0} == '{1}'", pkey, where);
                    axRecord.ExecuteStmt(sql);

                    do
                    {
                        if (axRecord.Found)
                        {
                            if (axRecord.ValidateDelete())
                            {
                                axRecord.Delete();
                                ret = true;

                            }
                            else
                            {
                                ret = false;
                                ax.CallStaticClassMethod("IWS_CAMErrorInfo", "throwInfo");
                                ax.TTSAbort();
                            }
                        }
                    } while (axRecord.Next());
                    ax.TTSCommit();
                }
                ax.Logoff();
            }
            catch (Exception ex)
            {
                ax.TTSAbort();
                ax.Logoff();
                //MessageBox.Show(ex.Message);
                //throw new Exception(ex.Message);
            }

            return ret;
        }

        public bool Delete(String tableName, String[] pkeys, Object[] wheres)
        {
            Boolean ret = false;
            Axapta ax = new Axapta();
            try
            {
                ax.Logon(null, null, null, m_configurationPath);
                //ax.LogonAs(m_userName, m_DoMain, m_nc, null, null, null, m_configurationPath);
                using (AxaptaRecord axRecord = ax.CreateAxaptaRecord(tableName))
                {
                    ax.TTSBegin();

                    String sql = string.Empty;
                    for (int i = 0; i < pkeys.Length; ++i)
                    {
                        if (i == 0)
                        {
                            if (typeof(String).Equals(wheres[i].GetType()))
                                sql = String.Format("select forupdate * from %1 where %1.{0} == '{1}'", pkeys[i], wheres[i]);
                            else
                                sql = String.Format("select forupdate * from %1 where %1.{0} == {1}", pkeys[i], wheres[i]);
                        }
                        else
                        {
                            if (typeof(String).Equals(wheres[i].GetType()))
                                sql += String.Format(" && %1.{0} == '{1}'", pkeys[i], wheres[i]);
                            else
                                sql += String.Format(" && %1.{0} == {1}", pkeys[i], wheres[i]);

                        }
                    }
                    axRecord.ExecuteStmt(sql);

                    do
                    {
                        if (axRecord.Found)
                        {
                            if (axRecord.ValidateDelete())
                            {
                                axRecord.Delete();
                                ret = true;

                            }
                            else
                            {
                                ret = false;
                                ax.CallStaticClassMethod("IWS_CAMErrorInfo", "throwInfo");
                                ax.TTSAbort();
                            }
                        }
                    } while (axRecord.Next());
                    ax.TTSCommit();
                }
                ax.Logoff();
            }
            catch (Exception ex)
            {
                ax.TTSAbort();
                ax.Logoff();
                //MessageBox.Show(ex.Message);
                //throw new Exception(ex.Message);
            }

            return ret;
        }

        /// <summary>
        /// Select Method
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="pkey">键名称</param>
        /// <param name="where">条件值</param>
        /// <param name="fieldList">字段列表</param>
        /// <returns></returns>
        public IList<Object> Select(String tableName, String pkey, String where, IList<String> fieldList)
        {
            IList<Object> ret;
            Axapta ax = new Axapta();
            NetworkCredential nc = new NetworkCredential("robert.huang", "abc@123", "supermask.com");
            try
            {
                ax.Logon(null, null, null, m_configurationPath);
                //ax.LogonAs(m_userName, m_DoMain, nc, null, null, null, null);
                ret = new List<Object>();

                using (AxaptaRecord axRecord = ax.CreateAxaptaRecord(tableName))
                {
                    String sql = String.Format("select * from %1 where %1.{0} == {1}", pkey, where);
                    axRecord.ExecuteStmt(sql);

                    do
                    {
                        if (axRecord.Found)
                        {
                            foreach (String field in fieldList)
                            {
                                ret.Add(axRecord.get_Field(field));
                            }
                        }
                    } while (axRecord.Next());

                }
                ax.Logoff();
            }
            catch (Exception ex)
            {
                ax.Logoff();
                throw new Exception(ex.Message);
            }

            return ret;
        }

        /// <summary>
        /// Call Method
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="callName">方法名称</param>
        /// <param name="parmList">参数列表</param>
        /// <returns></returns>
        public object Call(String tableName, String callName, params Object[] parmList)
        {
            Object ret = null;
            Axapta ax = new Axapta();

            try
            {
                ax.Logon(null, null, null, m_configurationPath);
                //ax.LogonAs(m_userName, m_DoMain, m_nc, null, null, null, m_configurationPath);

                using (AxaptaRecord axRecord = ax.CreateAxaptaRecord(tableName))
                {
                    ret = axRecord.Call(callName, parmList);
                }
                ax.Logoff();
            }
            catch (Exception ex)
            {
                ax.Logoff();
                throw new Exception(ex.Message);
            }

            return ret;
        }

        /// <summary>
        /// Call Table Method
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="callName">方法名称</param>
        /// <returns></returns>
        public object Call(String tableName, String callName)
        {
            return Call(tableName, callName, null);
        }

        /// <summary>
        /// Call StaticClass Method
        /// </summary>
        /// <param name="className">类名称</param>
        /// <param name="methodName">方法名称</param>
        /// <returns></returns>
        public object CallStaticClass(String className, String methodName)
        {
            return CallStaticClass(className, methodName, null);
        }

        /// <summary>
        /// Call StaticClass Method
        /// </summary>
        /// <param name="className">类名称</param>
        /// <param name="methodName">方法名称</param>
        /// <param name="paramList">参数列表</param>
        /// <returns></returns>
        public object CallStaticClass(String className, String methodName, params Object[] paramList)
        {
            object ret = null;
            Axapta ax = new Axapta();

            try
            {
                ax.Logon(null, null, null, m_configurationPath);
                ret = ax.CallStaticClassMethod(className, methodName, paramList);

                ax.Logoff();
            }
            catch (Exception ex)
            {
                ax.Logoff();
                throw new Exception(ex.Message);
            }

            return ret;
        }

        /// <summary>
        /// Call Job
        /// </summary>
        /// <param name="jobName">Job名称</param>
        public void CallJob(String jobName)
        {
            CallJob(jobName, null, null);
        }

        /// <summary>
        /// Call Job
        /// </summary>
        /// <param name="jobName">Job名称</param>
        /// <param name="className">类名称</param>
        public void CallJob(String jobName, String className)
        {
            CallJob(jobName, className, null);
        }

        /// <summary>
        /// Call Job
        /// </summary>
        /// <param name="jobName">Job名称</param>
        /// <param name="className">类名称</param>
        /// <param name="paramList">参数列表</param>
        public void CallJob(String jobName, String className, params Object[] paramList)
        {
            Axapta ax = new Axapta();
            AxaptaObject ao = null;

            if (className != null)
            {
                ao = ax.CreateAxaptaObject(className, paramList);
            }

            try
            {
                ax.Logon(null, null, null, m_configurationPath);

                ax.CallJob(jobName, ao);

                ax.Logoff();
            }
            catch (Exception ex)
            {
                ax.Logoff();
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Call Display Method 
        /// </summary>
        /// <param name="tableName">表名称</param>
        /// <param name="methodName">方法名称</param>
        /// <param name="findParam">参数列表</param>
        /// <returns></returns>

        public object CallDisplay(string tableName, string methodName, params object[] findParam)
        {
            object ret = null;
            Axapta ax = new Axapta();

            try
            {
                ax.Logon(null, null, null, m_configurationPath);
                using (AxaptaRecord axRecord = ax.CallStaticRecordMethod(tableName, "find", findParam) as AxaptaRecord)
                {
                    ret = axRecord.Call(methodName);
                }

                ax.Logoff();

            }

            catch (Exception ex)
            {
                ax.Logoff();
                throw new Exception(ex.Message);
            }
            return ret;
        }
    }
}
