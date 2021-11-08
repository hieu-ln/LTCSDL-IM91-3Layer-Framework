using System;
using System.Reflection;

namespace LTCSDL_IM91_3Layer_Sub3.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}