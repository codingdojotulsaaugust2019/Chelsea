using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ZombieProject.Models;
    
public class Message
{
    [Key]
    public int MessageId {get;set;}

    public bool Read {get;set;} = false;

    [Required]
    public string Content {get;set;}

    public int SenderId {get;set;}

    public User Sender {get;set;}

    public int TargetId {get;set;}

    public User Target {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;

}