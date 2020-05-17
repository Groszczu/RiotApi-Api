﻿using System.Threading.Tasks;
using Refit;
using RiotApiClient.Models;

namespace RiotApiClient
{
    public interface IRiotApiClient
    {
        [Get("/lol/summoner/v4/summoners/by-name/{summonerName}")]
        Task<Summoner> GetSummoner(string summonerName);

        [Get("/lol/match/v4/matchlists/by-account/{accountId}")]
        Task<MatchList> GetMatchList(string accountId);
        
        [Get("/lol/match/v4/matches/{matchId}")]
        Task<MatchDetails> GetMatch(long matchId);
    }
}
