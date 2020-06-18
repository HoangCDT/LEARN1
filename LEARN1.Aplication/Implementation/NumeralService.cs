using AutoMapper;
using AutoMapper.QueryableExtensions;
using LEARN1.Application.Interfaces;
using LEARN1.Application.ViewModels;
using LEARN1.Data.Entities;
using LEARN1.Data.IRepositoties;
using LEARN1.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARN1.Application.Implementation
{
    public class NumeralService : INumeralService
    {
        private INumeralRepository _numeralRepository;
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        private MapperConfiguration _configMapper;

        public NumeralService(INumeralRepository numeralRepository, IUnitOfWork unitOfWork, IMapper mapper, MapperConfiguration configMapper)
        {
            _numeralRepository = numeralRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _configMapper = configMapper;
        }

        public NumeralViewModel Add(NumeralViewModel numeralVM)
        {
            var numeral = _mapper.Map<NumeralViewModel, Numeral>(numeralVM);
            _numeralRepository.Add(numeral);
            return numeralVM;
        }

        public void Delete(int id)
        {
            _numeralRepository.Remove(id);
        }

        public async Task<List<NumeralViewModel>> GetAll()
        {
            return await _numeralRepository.FindAll().OrderBy(x => x.Id).ProjectTo<NumeralViewModel>(_configMapper).ToListAsync();
        }

        public async Task<List<NumeralViewModel>> GetAll(string keyword)
        {
            return await _numeralRepository.FindAll(x=>x.NumeralCode.Contains(keyword)|| x.NumeralName.Contains(keyword))
                .OrderBy(x => x.Id).ProjectTo<NumeralViewModel>(_configMapper).ToListAsync();
        }

        public List<NumeralViewModel> GetAllByParentId(int parentId)
        {
            throw new NotImplementedException();
        }

        public NumeralViewModel GetById(int Id)
        {
            return _numeralRepository.FindAll(x => x.Id == Id)
                                 .OrderBy(x => x.Id)
                                 .ProjectTo<NumeralViewModel>(_configMapper)
                                 .FirstOrDefault();
        }

        public async Task<List<NumeralViewModel>> GetHomeClew(int top)
        {
            return await _numeralRepository.FindAll().OrderBy(x => x.Id)
                                     .ProjectTo<NumeralViewModel>(_configMapper)
                                     .Take(top)
                                     .ToListAsync();
        }

        public void ReOrder(int sourceId, int targetId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(NumeralViewModel baseVm)
        {
            throw new NotImplementedException();
        }

        public void UpdateParentId(int sourceId, int targetId, Dictionary<int, int> items)
        {
            throw new NotImplementedException();
        }
    }
}
