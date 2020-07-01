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
      var sitecoreItemDataField = indexableField as SitecoreItemDataField;
      if (sitecoreItemDataField != null)
      {
        Field field = sitecoreItemDataField.Field;
        if (field.GetValue(true, false) != null)
        {
          var dateField = FieldTypeManager.GetField(field) as DateField;
          return dateField?.DateTime;
        }
      }
      return null;
    }
  }
}
