using Domain.BaseEntity;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class AppUser : IdentityUser, IBaseEntity, ISoftDelete
    {
        public string DisplayName { get; set; }
        public string? Bio { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsSoftDeleted { get; set; }
    }
}
