//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataFac
{
    using System;
    using System.Collections.Generic;
    
    public partial class S_Record
    {
        public int id { get; set; }
        public System.DateTime dtime { get; set; }
        public int reader_id { get; set; }
        public int book_id { get; set; }
    
        public virtual S_Book S_Book { get; set; }
        public virtual S_Person S_Person { get; set; }
    }
}
