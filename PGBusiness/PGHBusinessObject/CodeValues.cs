using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGBusiness.Entities
{
    public sealed class CodeValues
    {
        private static List<CodeValue> _codeValues = new List<CodeValue>();
        public static bool IsLoaded { get; private set; }

        private CodeValues() { }
        public static List<CodeValue> GetAll
        {
            get
            {
                return _codeValues;
            }
        }

        public static void Set(CodeValue codeValue)
        {
            IsLoaded = true;
            _codeValues.Add(codeValue);
        }

        public static void SetCodeValues(List<CodeValue> codeValues)
        {
            IsLoaded = true;
            codeValues.ForEach(cd =>
            {
                _codeValues.Add(cd);
            });
        }

        public static List<CodeValue> Get(string codeValueType)
        {
            List<CodeValue> codeValues;

            codeValues = _codeValues.Where(c => c.CodeValueType.ToLower().Equals(codeValueType.ToLower())).ToList();

            return codeValues;
        }

        public static CodeValue GetCodeValue(string codeValueType, int code)
        {
            CodeValue codeValue;

            codeValue = _codeValues.Where(c => c.CodeValueType.ToLower().Equals(codeValueType.ToLower()) && c.Code.Equals(code)).First();

            return codeValue;
        }

    }
}
