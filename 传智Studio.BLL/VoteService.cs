﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 传智Studio.Model;

namespace 传智Studio.BLL
{
   public class VoteService:BaseService<Vote>
    {
        public override void SetCurrentDal()
        {
            this.CurrentDal = this.CurrentDBSession.votedal;
        }
    }
}
