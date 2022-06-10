using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                { 
                    RoleId = "27d875f5-2d8d-5314-a08a-f000e8a57577",
                    UserId = "47d875e0-2d8c-5394-a38d-f021e8d57597"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "17d845f5-0c2d-5314-a08a-c000e8d57577",
                    UserId = "12d873d0-2d8c-0396-f31d-a320e8c57561"
                }
            );
        }
    }
}