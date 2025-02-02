﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DoctorManager : IDoctorService
    {
        IDoctorDal _doctorDal;

        public DoctorManager(IDoctorDal doctorDal)
        {
            _doctorDal = doctorDal;
        }

        public void Add(Doctor doctor)
        {
            _doctorDal.Add(doctor);
        }

        public void Delete(Doctor doctor)
        {
            _doctorDal.Delete(doctor);
        }

        public List<Doctor> GetAll()
        {
            return _doctorDal.GetAll();
        }

        public Doctor GetById(int doctorId)
        {
            return _doctorDal.Get(u => u.DoctorId == doctorId);
        }

        public void Update(Doctor doctor)
        {
            _doctorDal.Update(doctor);
        }
    }
}
