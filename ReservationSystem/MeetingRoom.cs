//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Meeting_room_dating
{
    using System;
    using System.Collections.Generic;
    
    public partial class MeetingRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MeetingRoom()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    
        public string Name { get; set; }
        public string Position { get; set; }
        public Nullable<int> LoadNumber { get; set; }
        public string Status { get; set; }
        public string Information { get; set; }
        public string Equipment { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
