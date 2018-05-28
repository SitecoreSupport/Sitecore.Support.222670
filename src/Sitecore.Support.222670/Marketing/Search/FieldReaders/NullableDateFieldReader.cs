using Sitecore.ContentSearch;
using Sitecore.Data.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Marketing.Search.FieldReaders
{
  public class NullableDateFieldReader : Sitecore.ContentSearch.FieldReaders.FieldReader
  {
    public override object GetFieldValue(IIndexableDataField indexableField)
    {
      Field field = (Field)(indexableField as SitecoreItemDataField);
      if ((field == null) || (field.GetValue(false, false) != null))
      {
        DateField field2 = FieldTypeManager.GetField(field) as DateField;
        if (field2 != null)
        {
          return field2.DateTime;
        }
      }
      return null;
    }
  }
}