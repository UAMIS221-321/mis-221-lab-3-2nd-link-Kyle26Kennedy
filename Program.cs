// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
class CollegeStadiumAndGameRecommendation {


static string GetEnjoymentLevel () {

    Console.WriteLine("Enter your desired level of enjoyment from the following (Boring, Average, Fun, Epic)");
    return Console.ReadLine();
}

static string GetStadiumRecommendations(string enjoymentLevel){

if(enjoymentLevel == "Boring") {
    return "Neyland Stadium";
}
else if(enjoymentLevel == "Average"){

    return "Jordan-Hare Stadium";
}
else if(enjoymentLevel == "Fun"){

    return "Tiger Stadium";
}
else if(enjoymentLevel == "Epic"){

    return "Saban Field at Bryant-Denny Stadium";
}
else{

    return "No recommendation";
}
}

static string GetGameRecommendations(string stadium){

    if(stadium == "Neyland Stadium"){

        return "Kent State";
    }
    else if(stadium == "Jordan-Hare Stadium"){
        
        return "Kentucky";
    }
    else if(stadium == "Tiger Stadium"){

        return "Alabama";
    }
    else if(stadium == "Saban Field at Bryant-Denny Stadium"){

        return "Auburn";
    }
    else {

        return "No recommendation";
    }

}

static void DisplayStadiumDetails(string stadium, string game){

    Console.WriteLine("Your stadium recommendation is " + stadium);
    Console.WriteLine("vs. " + game);
}

static void Main() {

    string enjoymentLevel = GetEnjoymentLevel();
    string stadium = GetStadiumRecommendations(enjoymentLevel);
    string game = GetGameRecommendations(stadium);
    DisplayStadiumDetails(stadium, game);
}

}


