namespace HightScore.Entities.Model.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;

        public BaseEntity()
        {
            CreatedTime = DateTime.Now;
        }
    }
}
