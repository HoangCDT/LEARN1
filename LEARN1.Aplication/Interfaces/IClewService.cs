using LEARN1.Application.ViewModels;
using LEARN1.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LEARN1.Application.Interfaces
{
    public interface IClewService
    {
        ClewViewModel Add(ClewViewModel clewVm);
        void Update(ClewViewModel clewVm);
        void Delete(int id);
        List<ClewViewModel> GetAll();
        List<ClewViewModel> GetAll(string keyword);
        List<ClewViewModel> GetAllByParentId(int parentId);
        ClewViewModel GetById(int Id);
        void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items);
        void ReOrder(int sourceId, int targetId);
        List<ClewViewModel> GetHomeClew(int top);
        void Save();
    }
}
