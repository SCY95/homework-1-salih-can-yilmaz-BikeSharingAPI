﻿using BikeSharingAPI.Models;
using BikeSharingAPI.Models.DTOs.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeSharingAPI.Services.IServices
{
    public interface ISessionRepository
    {
        List<Session> GetAll();
        List<Session> GetAll(Func<Session, bool> wherePredicate);
        List<Session> GetAll(params string[] columns);
        List<Session> GetAll(Func<Session, bool> wherePredicate, params string[] columns);
        List<Session> GetAll(string orderByParams);
        List<Session> GetAll(Func<Session, bool> wherePredicate, string orderByParams);
        List<Session> GetAll(string orderByParams, params string[] columns);
        List<Session> GetAll(Func<Session, bool> wherePredicate, string orderByParams, params string[] columns);
        Session GetById(Guid id);
        bool Create(Session session);
        bool Update(Session session);
        bool Delete(Guid id);
    }
}
