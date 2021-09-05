using ERP.Data.Entities;
using ERP.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Domain.RuleEngine.Handlers.IstenAyrılmaNeden
{
   public interface IIstenAyrılmaNedenRuleHandler
    {
        IRuleValidationResult ValidateIstenAyrılmaNedenEkle(IIstenAyrilmaNedenleriRepository ıstenAyrilmaNedenleriRepository, istenAyrilmaNedenleri istenAyrilmaNedenleri);

        IRuleValidationResult ValidateIstenAyrılmaNedenGuncelle(IIstenAyrilmaNedenleriRepository ıstenAyrilmaNedenleriRepository,  istenAyrilmaNedenleri istenAyrilmaNedenleri);

        IRuleValidationResult ValidateIstenAyrılmaNedenSil(IIstenAyrilmaNedenleriRepository ıstenAyrilmaNedenleriRepository, istenAyrilmaNedenleri istenAyrilmaNedenleri);
    }
}
