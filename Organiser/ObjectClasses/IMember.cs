﻿namespace Organiser.ObjectClasses
{
    public interface IMember
    {
        bool IsTeamLeader { get; set; }
        string LastName { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        string Username { get; set; }
    }
}