
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using ClashOfClans;
using ClashOfClans.Models;
using ClashOfClans.Search;
using System;
using System.Linq;
using System.Threading.Tasks;

public class COCApiCaller
{
    private Task mytask;

    // private string apiToken Mein Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImtpZCI6IjI4YTMxOGY3LTAwMDAtYTFlYi03ZmExLTJjNzQzM2M2Y2NhNSJ9.eyJpc3MiOiJzdXBlcmNlbGwiLCJhdWQiOiJzdXBlcmNlbGw6Z2FtZWFwaSIsImp0aSI6IjgyNzZiYWE5LWQ4YTktNGUyMy04ZDU2LTUzOGYyZDgzZDMwYiIsImlhdCI6MTc3MDQ5MjE5Nywic3ViIjoiZGV2ZWxvcGVyLzU4NmZiOWE0LWRiYTMtMzc1MS0wZjkxLTZjYTJkYzBiZmVmYyIsInNjb3BlcyI6WyJjbGFzaCJdLCJsaW1pdHMiOlt7InRpZXIiOiJkZXZlbG9wZXIvc2lsdmVyIiwidHlwZSI6InRocm90dGxpbmcifSx7ImNpZHJzIjpbIjkxLjY0LjI3LjExMCJdLCJ0eXBlIjoiY2xpZW50In1dfQ.g9716HxoZdsBhFFIXpBKOiJPylPVjFRSLLG9uY3ePCSHVFTLJ9OFu-aCcKvKhnwWW8Ds6aHjV-bc3xS1Nzc1ew";
    private readonly string TomsAPIToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImtpZCI6IjI4YTMxOGY3LTAwMDAtYTFlYi03ZmExLTJjNzQzM2M2Y2NhNSJ9.eyJpc3MiOiJzdXBlcmNlbGwiLCJhdWQiOiJzdXBlcmNlbGw6Z2FtZWFwaSIsImp0aSI6IjRkZWZiZjJiLWIzZjctNDVjNy1iYTUyLTExNzc5NmEwYTQxNSIsImlhdCI6MTc3MTI2MjA2NCwic3ViIjoiZGV2ZWxvcGVyL2JhNTE3N2NmLThjNzktYjFjNy00ZWMyLTA2ODFjZmVhOWQ4NCIsInNjb3BlcyI6WyJjbGFzaCJdLCJsaW1pdHMiOlt7InRpZXIiOiJkZXZlbG9wZXIvc2lsdmVyIiwidHlwZSI6InRocm90dGxpbmcifSx7ImNpZHJzIjpbIjkxLjY0LjI3LjExMCJdLCJ0eXBlIjoiY2xpZW50In1dfQ.1cieEgrerdk20IZgkj3-nvKNgT2lgKmRiVIXRzIx7k9c8tfFCoKxwMX3gcsi6hvlDZkv9y6b5j4Z80arPIg6xQ";
    private string playerTag = "#G90L2L9U2";
    // private string secondPlayerTag = "#R8L9GG22C";
    private string secondPlayerTag = "#RR09LY88";
    private string clanTag = "#2GYCYY2U8";

    public COCApiCaller()
    {
        Console.WriteLine("COCApiCaller");
        myApiCall();
        // mytask = makeCall();
    }

    public void PrintIntoConsole()
    {
        Console.WriteLine("COCApiCaller PrintIntoConsole");
    }

    private async void myApiCall()
    {
        ClashOfClansClient coc = new ClashOfClansClient(TomsAPIToken);
        // Console.WriteLine("Calling Clan Inforation");
        // Clan clan = await coc.Clans.GetClanAsync(clanTag);
        // Console.WriteLine($"Clan '{clan.Name}' is a level {clan.ClanLevel} clan and has {clan.Members} members");
        Player player = await coc.Players.GetPlayerAsync(playerTag);
        Console.WriteLine($"Player info: {player.Name}, {player.ExpLevel}");
        Player player2 = await coc.Players.GetPlayerAsync(secondPlayerTag);
        Console.WriteLine($"Player info: {player2.Name}, {player2.ExpLevel}");
        Console.WriteLine($"League Infos:");

        Console.WriteLine(player2.LegendStatistics == null);
        PlayerLegendStatistics playerLegendStats = player2.LegendStatistics;
        Console.WriteLine($"Player {player2.Name} has {playerLegendStats.LegendTrophies}");
        LegendLeagueTournamentSeasonResult a = playerLegendStats.CurrentSeason;
        Console.WriteLine($"CurrentSeason {a.Rank} {a.Trophies}");

        // Console.WriteLine($"BestSeason {playerLegendStats.BestSeason}");
        // Console.WriteLine($"CurrentSeason {playerLegendStats.CurrentSeason}");
        // Console.WriteLine($"PreviousSeason {playerLegendStats.PreviousSeason}");
        // Console.WriteLine($" {playerLegendStats.}");


        // League league1
        // LeagueList leagues = (LeagueList)await coc.Leagues.GetLeaguesAsync();
        // var legendLeague = leagues["Legend League"];
        // var leagueSeasons = (LeagueSeasonList)await coc.Leagues.GetLeagueSeasonsAsync(legendLeague!.Id);
        // var lastSeason = leagueSeasons.Last();
        // var query = new Query
        // {
        //     Limit = 100
        // };

        // var league = await coc.Leagues.GetLeagueAsync(legendLeague.Id);

        // Console.WriteLine($"Id: {league.Id} = {league.Name}");

        // Console.WriteLine($"League Season: {lastSeason.Id}");

        // PlayerRankingList playerRankings = (PlayerRankingList)await coc.Leagues.GetLeagueSeasonRankingsAsync(legendLeague.Id, lastSeason.Id, query);

        // foreach (var tempplayer in playerRankings)
        // {
        //     Console.WriteLine($"{tempplayer.Rank}. {tempplayer.Name}, {tempplayer.Trophies} \uD83C\uDFC6, attacks won {tempplayer.AttackWins}, defenses won {tempplayer.DefenseWins}");
        // }

        // player2.LegendStatistics.

        // LegendLeagueTournamentSeasonResult lltsr = coc.Leagues.


    }

    // private async Task makeCall()
    // {

    //     // my player api b4t3kns4

    //     // Encode the # in the tag
    //     string encodedTag = Uri.EscapeDataString(playerTag);

    //     using HttpClient client = new HttpClient();

    //     // Required headers
    //     client.DefaultRequestHeaders.Authorization =
    //         new AuthenticationHeaderValue("Bearer", TomsAPIToken);
    //     client.DefaultRequestHeaders.Accept.Add(
    //         new MediaTypeWithQualityHeaderValue("application/json"));

    //     string url = $"https://api.clashofclans.com/v1/players/{encodedTag}";

    //     try
    //     {
    //         Console.WriteLine("Starting apiCall:");

    //         HttpResponseMessage response = await client.GetAsync(url);

    //         if (!response.IsSuccessStatusCode)
    //         {
    //             Console.WriteLine($"Error: {response.StatusCode}");
    //             Console.WriteLine(await response.Content.ReadAsStringAsync());
    //             return;
    //         }
    //         Console.WriteLine("Response worked:");

    //         string json = await response.Content.ReadAsStringAsync();

    //         // Print raw JSON
    //         Console.WriteLine("RAW RESPONSE:");
    //         Console.WriteLine(json);

    //         // Deserialize to object
    //         var player = JsonSerializer.Deserialize<OldPlayer>(json);

    //         Console.WriteLine("\nParsed Data:");
    //         Console.WriteLine($"Name: {player.name}");
    //         Console.WriteLine($"Town Hall: {player.townHallLevel}");
    //         Console.WriteLine($"Trophies: {player.trophies}");
    //         Console.WriteLine($"Level: {player.expLevel}");
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.WriteLine(ex.Message);
    //     }
    // }
}

