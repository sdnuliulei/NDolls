﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDolls.Data.Entity;
using System.Data;

namespace NDolls.Data
{
    public interface IRepository<T> where T:EntityBase
    {
        List<Attribute.CustomAttribute> GetCustomFieldsByType(String type);

        List<T> FindAll();
        List<T> Find(T model);
        List<T> Find(int top, T model);
        List<T> FindByCondition(List<Item> items);
        List<T> FindByCondition(Item item);
        List<T> FindByCondition(int top, List<Item> items);
        List<T> FindByPage(int pageCount, int index, List<Item> items);
        T FindByPK(string keyValue);
        T FindByPK(string[] keyValues);
        List<T> Find(String customCondition);
        int GetCount(List<Item> items);
        int GetCount(String customCondition);

        String Validate(T entity);

        bool Add(T model);
        bool Update(T model);
        bool Update(T model, OptType type);
        bool AddOrUpdate(T model);
        bool Delete(string keyValue);
        bool Delete(string[] keyValues);
        bool DeleteByCondition(Item item);
        bool DeleteByCondition(List<Item> items);
        bool Exist(T model);
        bool Exist(List<Item> items);
    }
}
