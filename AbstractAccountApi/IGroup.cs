﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace AbstractAccountApi
{
    public interface IGroup
    {
        string Name { set; get; }
        string Description { set; get; }
        GroupType Type { set; get; }
        string Code { set; get; }
        string Untis { set; get; }
        bool Visible { set; get; }
        bool Official { set; get; }
        string CoAccountLabel { set; get; }
        int AdminNumber { set; get; }
        string InstituteNumber { set; get; }
        List<string> Titulars { set; get; }

        IGroup Parent { set; get; }
        List<IGroup> Children { set; get; }
        List<IAccount> Accounts { set; get; }

        IGroup Find(string name);
        bool HasParent(string name);
        int Count { get; }
        int CountClassGroupsOnly { get; }
        int NumAccounts();
        void Sort();
        void GetTreeAsList(List<IGroup> list);

        Task LoadAccounts();
        void ApplyImportRules(List<IRule> rules);

        JObject ToJson(bool includeAccounts);
        bool Equals(IGroup other, bool recursive, bool includeAccounts);
    }
}
