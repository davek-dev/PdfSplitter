using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace PdfSplitter.Models;

public abstract class BindableModelBase : BindableObject, INotifyPropertyChanged
{
    protected void NotifyPropertyChanged<T>(Expression<Func<T>> property)
    {
        if(this.OnPropertyChanged!= null)
        {
            OnPropertyChanged(GetMemberInfo(property).Name);
        }
    }

    private static MemberInfo GetMemberInfo(LambdaExpression expression) 
    {
        var e = expression.Body as MemberExpression;
        return e.Member;         
    }
}
