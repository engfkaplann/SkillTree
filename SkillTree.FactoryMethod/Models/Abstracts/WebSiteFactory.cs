﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTree.FactoryMethod.Models.Abstracts
{
    public abstract class WebSiteFactory
    {
        public abstract WebSite CreateWebSite();
    }
}
