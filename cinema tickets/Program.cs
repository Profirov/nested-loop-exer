int studentTicketCount = 0; 
int standartTicketCount  = 0;   
int kidTicketCount  = 0;

string movieName;

while((movieName = Console.ReadLine()) !="Finish")
{
    int freeSeats = int.Parse(Console.ReadLine());
    int takenSeats = 0;
    string ticketType;

    while(takenSeats < freeSeats && (ticketType = Console.ReadLine()) != "End")
    { 
    takenSeats++;
        switch(ticketType)
        {
            case "students":
                studentTicketCount++;
                break;
            case "standart":
                standartTicketCount++; 
                break;
            case "kid":
                kidTicketCount++; 
                break;
            default:
                break;
        }
    }
    double projectionPercentage = ((double)takenSeats / freeSeats) * 100;
    Console.WriteLine($"{movieName} - {projectionPercentage:f2}% full.");


}
int totalTicketsCount = studentTicketCount + standartTicketCount + kidTicketCount;
double studentPercentage = ((double)studentTicketCount / totalTicketsCount) * 100;
double standardPercentage = ((double)standartTicketCount / totalTicketsCount) * 100;
double kidPercentage = ((double)kidTicketCount / totalTicketsCount) * 100;
Console.WriteLine($"Total tickets: {totalTicketsCount}.");
Console.WriteLine($"{studentPercentage:f2}% student tickets.");
Console.WriteLine($"{standardPercentage:f2}% standart tickets.");
Console.WriteLine($"{kidPercentage:f2}% kids tickets.");