using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractAccountApi.ObservableProperties;

namespace AbstractAccountApi
{
    public enum Rule
    {
        // Smartschool Import Rules
        SS_DiscardGroup,
        SS_NoSubGroups,

        // Wisa Import Rules
        WI_ReplaceInstitution,
        WI_DontImportClass,
    }

    public enum RuleType
    {
        SS_Import,
        WISA_Import,
    }

    public enum RuleAction
    {
        Discard,
        Modify,
    }

    public interface IRule
    {
        Rule Rule { get; }
        RuleType RuleType { get; }
        RuleAction RuleAction { get; }

        string Header { get; }
        string Description { get; }
        Prop<string> ShortInfo { get; }

        bool Enabled { get; set; }

        JObject ToJson();
        void setConfig(int ID, string data);
        string getConfig(int ID);

        bool ShouldApply(object obj);
        void Modify(object obj);
    }
}
