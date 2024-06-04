﻿using Dal.DalApi;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalImplementation
{
    public class BusinessRepo : IBusinessRepo
    {
        SiteContext siteContext;
        public BusinessRepo(SiteContext siteContext)
        {
            this.siteContext = siteContext;
        }
        public List<Business> GetAll()
        {
            return siteContext.Businesses.ToList();
        }
        public Business Create(Business item)
        {
            siteContext.Businesses.Add(item);
            siteContext.SaveChanges();
            return item;
        }
        public Business Update(int Id, Business business)
        {
            Business businessToUpdate = siteContext.Businesses.FirstOrDefault(b => b.Id == Id);
            siteContext.Businesses.Update(business);
            siteContext.SaveChanges();
            return business; 
        }

        public Business Delete(int id)
        {
            throw new NotImplementedException();
        }

       

      
    }
}
