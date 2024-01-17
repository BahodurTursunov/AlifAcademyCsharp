namespace Practice_HW18
{
    public class BaseEntity
    {
        public virtual int ID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }

        protected void Delete()
        {
            IsDeleted = true;
        }
    }
}
