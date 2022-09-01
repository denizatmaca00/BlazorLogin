namespace BlazorAuthServer.Models
{
    public class Role
    {
        public int RoleId { get; set; } 
        public int UserId { get; set; }
        public string Administor { get; set; }    
        public string UserRole { get; set; }    
        public string CounterRole { get; set; }    
        
    }
}
