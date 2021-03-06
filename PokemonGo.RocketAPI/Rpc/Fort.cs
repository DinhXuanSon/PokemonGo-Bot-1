﻿#region using directives

using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Google.Protobuf;
using POGOProtos.Data.Battle;
using POGOProtos.Inventory.Item;
using POGOProtos.Networking.Requests;
using POGOProtos.Networking.Requests.Messages;
using POGOProtos.Networking.Responses;
using PokemonGo.RocketAPI.Exceptions;
using PokemonGo.RocketAPI.Helpers;

#endregion

namespace PokemonGo.RocketAPI.Rpc
{
    public class Fort : BaseRpc
    {
        public Fort(Client client) : base(client)
        {
        }

        public async Task<FortDetailsResponse> GetFort(string fortId, double fortLatitude, double fortLongitude)
        {
            var request = new Request
            {
                RequestType = RequestType.FortDetails,
                RequestMessage = ((IMessage)new FortDetailsMessage
                {
                    FortId = fortId,
                    Latitude = fortLatitude,
                    Longitude = fortLongitude
                }).ToByteString()
            };

            return await PostProtoPayloadCommonR<Request, FortDetailsResponse>(request).ConfigureAwait(false);
        }

        public async Task<FortSearchResponse> SearchFort(string fortId, double fortLat, double fortLng)
        {
            var request = new Request
            {
                RequestType = RequestType.FortSearch,
                RequestMessage = ((IMessage)new FortSearchMessage
                {
                    FortId = fortId,
                    FortLatitude = fortLat,
                    FortLongitude = fortLng,
                    PlayerLatitude = Client.CurrentLatitude,
                    PlayerLongitude = Client.CurrentLongitude
                }).ToByteString()
            };

            return await PostProtoPayloadCommonR<Request, FortSearchResponse>(request).ConfigureAwait(false);
        }

        public AddFortModifierResponse AddFortModifier(string fortId, ItemId modifierType)
        {
            var message = new AddFortModifierMessage
            {
                FortId = fortId,
                ModifierType = modifierType,
                PlayerLatitude = Client.CurrentLatitude,
                PlayerLongitude = Client.CurrentLongitude
            };

            return PostProtoPayloadCommonR<Request, AddFortModifierResponse>(RequestType.AddFortModifier, message).Result;
        }

        public GymBattleAttackResponse GymBattleAttack(string fortId, string battleId, List<BattleAction> battleActions,
            BattleAction lastRetrievedAction, long timestampMs)
        {
            var message = new GymBattleAttackMessage
            {
                BattleId = battleId,
                GymId = fortId,
                LastRetrievedAction = lastRetrievedAction,
                PlayerLatDegrees = Client.CurrentLatitude,
                PlayerLngDegrees = Client.CurrentLongitude,
                AttackActions = { battleActions },
                TimestampMs = timestampMs //(long)(Utils.GetTime(true))
            };

            return PostProtoPayloadCommonR<Request, GymBattleAttackResponse>(RequestType.GymBattleAttack, message).Result;
        }

        public GymDeployResponse GymDeployPokemon(string fortId, ulong pokemonId)
        {
            var message = new GymDeployMessage
            {
                PokemonId = pokemonId,
                FortId = fortId,
                PlayerLatitude = Client.CurrentLatitude,
                PlayerLongitude = Client.CurrentLongitude
            };

            return PostProtoPayloadCommonR<Request, GymDeployResponse>(RequestType.GymDeploy, message).Result;
        }

        public GymFeedPokemonResponse GymFeedPokemon(string fortId, ulong pokemonId)
        {
            var message = new GymFeedPokemonMessage
            {
                PokemonId = pokemonId,
                GymId = fortId,
                PlayerLatDegrees = Client.CurrentLatitude,
                PlayerLngDegrees = Client.CurrentLongitude
            };

            return PostProtoPayloadCommonR<Request, GymFeedPokemonResponse>(RequestType.GymFeedPokemon, message).Result;
        }

        public FortRecallPokemonResponse FortRecallPokemon(string fortId, ulong pokemonId)
        {
            var message = new FortRecallPokemonMessage
            {
                PokemonId = pokemonId,
                FortId = fortId,
                PlayerLatitude = Client.CurrentLatitude,
                PlayerLongitude = Client.CurrentLongitude
            };

            return PostProtoPayloadCommonR<Request, FortRecallPokemonResponse>(RequestType.FortRecallPokemon, message).Result;
        }

        public GymGetInfoResponse GymGetInfo(string gymId, double gymLat, double gymLng)
        {
            var message = new GymGetInfoMessage
            {
                GymId = gymId,
                GymLatDegrees = gymLat,
                GymLngDegrees = gymLng,
                PlayerLatDegrees = Client.CurrentLatitude,
                PlayerLngDegrees = Client.CurrentLongitude
            };
            return PostProtoPayloadCommonR<Request, GymGetInfoResponse>(RequestType.GymGetInfo, message).Result;
        }

        public async Task<GymStartSessionResponse> GymStartSession(string gymId, ulong defendingPokemonId, IEnumerable<ulong> attackingPokemonIds)
        {
            var message = new GymStartSessionMessage {
                GymId = gymId,
                DefendingPokemonId = defendingPokemonId,
                PlayerLatDegrees = Client.CurrentLatitude,
                PlayerLngDegrees = Client.CurrentLongitude,
            };
            message.AttackingPokemonId.Add(attackingPokemonIds.ToArray());
            //foreach (var element in attackingPokemonIds) {
            //    message.AttackingPokemonId.Add(element);
            //}

            return await PostProtoPayloadCommonR<Request, GymStartSessionResponse>(RequestType.GymStartSession, message).ConfigureAwait(false);

        }
    }
}