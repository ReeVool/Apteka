//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apteka.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Клиенты
    {
        public int Код_клиента { get; set; }
        public int Код_товара { get; set; }
        public int Код_производителя { get; set; }
        public string Наименование { get; set; }
        public string Банк { get; set; }
        public string Телефон { get; set; }
        public string Контактное_лицо { get; set; }
        public string Email { get; set; }
        public string Адрес { get; set; }
    }
}
