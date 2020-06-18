using LEARN1.Application.ViewModels;
using LEARN1.Data.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LEARN1.Application.Interfaces
{
    public interface INumeralService
    {
        NumeralViewModel Add(NumeralViewModel clewVm);
        void Update(NumeralViewModel clewVm);
        void Delete(int id);
        Task<List<NumeralViewModel>> GetAll();
        Task<List<NumeralViewModel>> GetAll(string keyword);
        List<NumeralViewModel> GetAllByParentId(int parentId);
        NumeralViewModel GetById(int Id);
        void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items);
        void ReOrder(int sourceId, int targetId);
        Task<List<NumeralViewModel>> GetHomeClew(int top);
        void Save();

    }
}
