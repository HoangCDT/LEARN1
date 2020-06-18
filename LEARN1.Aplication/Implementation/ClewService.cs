using AutoMapper;
using AutoMapper.QueryableExtensions;
using LEARN1.Application.Interfaces;
using LEARN1.Application.ViewModels;
using LEARN1.Data.Entities;
using LEARN1.Data.IRepositoties;
using LEARN1.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LEARN1.Application.Implementation
{
    public class ClewService : IClewService
    {
        private IClewRepository _clewRepository;
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        private MapperConfiguration _configMapper;

        public ClewService(IClewRepository clewRepository, IUnitOfWork unitOfWork, IMapper mapper, MapperConfiguration configMapper)
        {
            _clewRepository = clewRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configMapper = configMapper;
        }

        public ClewViewModel Add(ClewViewModel clewVm)
        {
            var clew = _mapper.Map<ClewViewModel, Clew>(clewVm);
            _clewRepository.Add(clew);
            return clewVm;
        }

        public void Delete(int id)
        {
            _clewRepository.Remove(id);
        }

        public List<ClewViewModel> GetAll()
        {
            return _clewRepository.FindAll().OrderBy(x => x.Id).ProjectTo<ClewViewModel>(_configMapper).ToList();
        }

        public List<ClewViewModel> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _clewRepository.FindAll(x => x.ClewName.Contains(keyword) || x.ClewCode.Contains(keyword))
                    .OrderBy(x => x.Id)
                    .ProjectTo<ClewViewModel>(_configMapper).ToList();
            else 
                return _clewRepository.FindAll().OrderBy(x => x.Id).ProjectTo<ClewViewModel>(_configMapper).ToList();
        }

        public List<ClewViewModel> GetAllByParentId(int parentId)
        {
            throw new NotImplementedException();
        }

        public ClewViewModel GetById(int Id)
        {
            return _clewRepository.FindAll(x=>x.Id == Id)
                                  .OrderBy(x => x.Id)
                                  .ProjectTo<ClewViewModel>(_configMapper)
                                  .FirstOrDefault();
        }

        public List<ClewViewModel> GetHomeClew(int top)
        {
            return _clewRepository.FindAll().OrderBy(x => x.Id)
                                  .ProjectTo<ClewViewModel>(_configMapper)
                                  .Take(top)
                                  .ToList();
        }

        public void ReOrder(int sourceId, int targetId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ClewViewModel clewVm)
        {
            throw new NotImplementedException();
        }

        public void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items)
        {
            throw new NotImplementedException();
        }
    }
}
