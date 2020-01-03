using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using QYMSERVER.Entities.Test;
using QYMSERVER.TestApp.DTO;

namespace QYMSERVER.TestApp
{
    public class TestAppService : QYMSERVERAppServiceBase,ITestAppService
    {
        private readonly IRepository<TestEntity> _taskRepository;
        /// <summary>
        ///In constructor, we can get needed classes/interfaces.
        ///They are sent here by dependency injection system automatically.
        /// </summary>
        public TestAppService(IRepository<TestEntity> taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public int CreateTask(TestDto input)
        {
            //We can use Logger, it's defined in ApplicationService base class.
            Logger.Info("Updating a task for input: " + input);
            //var task = _taskRepository.Get(input.Id);

            //Creating a new Task entity with given input's properties
            var task = new TestEntity
            {
                Id = input.Id,
                AAA = input.AAA,
                BBB = input.BBB
            };
            //if (input.AAA.HasValue)
            //{
            //    task.AAA = _taskRepository.Load(input.AAA.Value);
            //}
            //Saving entity with standard Insert method of repositories.
            return _taskRepository.InsertAndGetId(task);
        }

        public void DeleteTask(int id)
        {
            var task = _taskRepository.Get(id);
            if (task != null)
            {
                _taskRepository.Delete(task);
            }
        }

        public IList<TestDto> GetAllTask()
        {
            throw new NotImplementedException();
        }

        public TestDto GetTaskByID(int id)
        {
            var task = _taskRepository.Get(id);
            return task.MapTo<TestDto>();
        }

        public async Task<TestDto> GetTaskByIdAsync(int id)
        {
            //Called specific GetAllWithPeople method of task repository.
            var task = await _taskRepository.GetAsync(id);
            //Used AutoMapper to automatically convert List<Task> to List<TaskDto>.
            return task.MapTo<TestDto>();
        }

        public void UpdateTask(TestDto input)
        {
            //We can use Logger, it's defined in ApplicationService base class.
            Logger.Info("Updating a task for input: " + input);
            //Retrieving a task entity with given id using standard Get method of repositories.
            var task = _taskRepository.Get(input.Id);
            //Updating changed properties of the retrieved task entity.
            if (input.AAA.HasValue)
            {
                task.AAA = input.AAA.Value;
            }
            //if (input.BBB.HasValue)
            //{
            //    task.AssignedPerson = _taskRepository.Load(input.AssignedPersonId.Value);
            //}
            //We even do not call Update method of the repository.
            //Because an application service method is a 'unit of work' scope as default.
            //ABP automatically saves all changes when a 'unit of work' scope ends (without any exception).
        }
    }
}
