using Construction_ListAdd;

TeamMate player1= new TeamMate() { NameSurname = "Didier Drogba", Age = 35, Number = 9 };
TeamMate player2 = new TeamMate() { NameSurname = "Wesley Sneijder", Age = 32, Number = 10};
TeamMate newplayer = new TeamMate();
TeamMate[] teamMate = new TeamMate[] { player1, player2};
TeamManager newplayer1 = new TeamManager();

newplayer1.TeamAdd();
newplayer = newplayer1.Item;

List<TeamMate> teamMates = new List<TeamMate>();
teamMates = teamMate.ToList();
teamMates.Add(newplayer); 
teamMates[2] = newplayer;
newplayer1.TeamList(teamMates);
//foreach (var z in teamMates)
//{
//    Console.WriteLine(z.NameSurname + " " + z.Age);
//}


//Console.WriteLine(player.NameSurname);


//Console.WriteLine(newplayer.NameSurname);


//foreach (var z in teamList)
//{
//    Console.WriteLine(z.NameSurname + " " + z.Number + " " +z.Age);
//}

// sonraki çalışma teammanager classında yeni bir array tanımlayıp onun üzerinden gitmeliyim.



