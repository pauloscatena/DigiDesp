using System;

namespace DigiDesp.Common.Types
{
    public class GlobalId: AbstractType<Guid>
    {        
        public static GlobalId NewId(){
            GlobalId result = new GlobalId();
            result.Set(Guid.NewGuid());
            return result;
        }
    }
}