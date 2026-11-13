
 class TaskItem
    {
   public int id { get; set; } 
    public string name { get; set; } = "  ";
    public DateTime Start {  get; set;}
    public DateTime End { get; set; }
    public Boolean IsCompleted { get; set; }
    public int FiledId {  get; set;}
    public Filed filed {  get; set;} 
    public int PriortyId {  get; set;}
    public Priorty Priorty { get; set; }
    public int UserId {  get; set;}
    public User User { get; set;}
  public  TaskItem()
    {
        
    }

}

