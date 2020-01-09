using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Hangfire;
using QYMSERVER.DoWork.MainProduct.Dto;
using QYMSERVER.Entities.IWS;
using QYMSERVER.Entities.Product;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QYMSERVER.DoWork.MainProduct
{
    
    public class LocalProductTableAppService: QYMSERVERAppServiceBase, ILocalProductTableAppService
    {
        private readonly IRepository<PRODTABLE> _PRODTABLERepository;
        private readonly IRepository<ROUTEOPRTABLE> _ROUTEOPRTABLERepository;
        public LocalProductTableAppService(IRepository<PRODTABLE> repository, IRepository<ROUTEOPRTABLE> repository1)
        {
            _PRODTABLERepository = repository;
            _ROUTEOPRTABLERepository = repository1;
        }
        #region  仓储方法
        //public ObservableCollection<PRODTABLE> Entities { get; }  给客户端提供数据结构
        ////例子一
        //var query = from person in _personRepository.GetAll()
        //            where person.IsActive
        //            orderby person.Name
        //            select person;
        //var people = query.ToList();

        ////例子二
        //List<Person> personList2 = _personRepository.GetAll().Where(p => p.Name.Contains("H")).OrderBy(p => p.Name).Skip(40).Take(20).ToList();


        #endregion
        /// <summary>
        /// 获取所有订单状态》=4的订单（》=4表示可以生产的状态订单）
        /// </summary>
        /// <returns></returns>
        public async Task<ObservableCollection<PRODTABLEDto>> GetProductByStatusAsync()
        {
            var temp= _PRODTABLERepository.GetAll().Where(p => p.PRODSTATUS >= 4).OrderBy(p => p.PRODPRIO).ToList();
            return temp.MapTo<ObservableCollection<PRODTABLEDto>>();
        }
        /// <summary>
        /// 获取指定PRODID的生产订单
        /// </summary>
        /// <param name="prodid"></param>
        /// <returns></returns>
        public PRODTABLEDto GetProductByID(string prodid)
        {
            var temp = _PRODTABLERepository.FirstOrDefault(pro => pro.PRODID == prodid);
            //var temp1 = _PRODTABLERepository.GetAll().Where(product=>product.PRODID ==prodid);
            return temp.MapTo<PRODTABLEDto>();
        }
        /// <summary>
        /// 插入一个生产订单（业务逻辑上是不允许的）
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task PostInsertOneProduct(PRODTABLE input)
        {
           await _PRODTABLERepository.InsertAndGetIdAsync(input);
        }
        /// <summary>
        /// 删除一个生产订单
        /// </summary>
        /// <param name="prodid"></param>
        public void DeleteOneProduct(string prodid)
        {
            var temp = _PRODTABLERepository.FirstOrDefault(pro => pro.PRODID == prodid);

            if (temp != null)
            {
                _PRODTABLERepository.Delete(temp);
            }
            RecurringJob.AddOrUpdate("MyCycle", () => Logger.Info("22222222222222222222222222222222222222222222222"), Cron.MinuteInterval(1));//这种写法的日志无法识别
            Logger.Info("RecurringJob.AddOrUpdate(666666666666666666666666)");
        }



        /// <summary>
        /// 获取所有工序种类 给界面做为筛选条件
        /// </summary>
        /// <returns></returns>
        public async Task<List<ROUTEOPRTABLEDto>> GetRouteProcessAsync()
        {
            var temp = await _ROUTEOPRTABLERepository.GetAllListAsync();
            return temp.MapTo<List<ROUTEOPRTABLEDto>>();
        }


    }
}
