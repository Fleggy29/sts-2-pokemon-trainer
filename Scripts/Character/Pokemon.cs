using System;
using System.Collections.Generic;
using BaseLib.Abstracts;
using BaseLib.Utils.NodeFactories;
using Godot;
using MegaCrit.Sts2.Core.Entities.Characters;
using MegaCrit.Sts2.Core.Entities.Players;
using MegaCrit.Sts2.Core.Entities.RestSite;
using MegaCrit.Sts2.Core.Models;
using Pokemon.Scripts.Cards;
// using Steve.SteveCode.Extensions;
// using Steve.SteveCode.Relics;
// using Steve.SteveCode.RestSite;

namespace Pokemon.Pokemon.Character;

public class TestCharacter : PlaceholderCharacterModel
{
    // Character name color
    public override Color NameColor => new(0.5f, 0.5f, 1f);
    // Energy icon outline color
    public override Color EnergyLabelOutlineColor => new(0.1f, 0.1f, 1f);
    // Map drawing color
    public override Color MapDrawingColor => new(0.5f, 0.5f, 1f);
    
    // Character gender
    public override CharacterGender Gender => CharacterGender.Masculine;

    // Starting HP
    public override int StartingHp => 80;

    // Character model tscn path. See below for customization.
    public override string CustomVisualPath => "res://Pokemon/scenes/trainer.tscn";
    // Card trail scene.
    public override string CustomTrailPath => "res://Pokemon/scenes/card_trail_pokemon.tscn";
    // Character portrait path.
    public override string CustomIconTexturePath => "res://Pokemon/scenes/pokemon_icon.tscn";
    // Top-left portrait, character stats portrait, daily challenge icon. This is a scene, not an image. See template assets below.
    // public override string CustomIconPath => "res://scenes/ui/character_icons/ironclad_icon.tscn";
    // Energy counter tscn path. See below for customization.
    public override string CustomEnergyCounterPath => "res://Pokemon/scenes/ironclad_energy_counter.tscn";
    // Rest site scene.
    // public override string CustomRestSiteAnimPath => "res://scenes/rest_site/characters/ironclad_rest_site.tscn";
    // Merchant scene.
    // public override string CustomMerchantAnimPath => "res://scenes/merchant/characters/ironclad_merchant.tscn";
    // Multiplayer - pointing finger.
    // public override string CustomArmPointingTexturePath => null;
    // Multiplayer rock-paper-scissors - rock.
    // public override string CustomArmRockTexturePath => null;
    // Multiplayer rock-paper-scissors - paper.
    // public override string CustomArmPaperTexturePath => null;
    // Multiplayer rock-paper-scissors - scissors.
    // public override string CustomArmScissorsTexturePath => null;

    // Character select background.
    public override string CustomCharacterSelectBg => "res://Pokemon/scenes/char_select.tscn";
    // Character select icon.
    public override string CustomCharacterSelectIconPath => "res://Pokemon/images/char_select_trainer.png";
    // Character select icon - locked state.
    // public override string CustomCharacterSelectLockedIconPath => "res://test/images/char_select_test_locked.png";
    // Character select transition animation.
    // public override string CustomCharacterSelectTransitionPath => "res://materials/transitions/ironclad_transition_mat.tres";
    // Map marker icon, emote wheel portrait.
    // public override string CustomMapMarkerPath => null;

    // Since BaseLib 3.1.1, sound effects can use resource paths like "res://test/audios/test.wav"
    // Attack SFX
    // public override string CustomAttackSfx => null;
    // Cast SFX
    // public override string CustomCastSfx => null;
    // Death SFX
    // public override string CustomDeathSfx => null;
    // Character select SFX
    // public override string CharacterSelectSfx => null;
    // Transition SFX. This one cannot be removed.
    public override string CharacterTransitionSfx => "event:/sfx/ui/wipe_ironclad";

    public override CardPoolModel CardPool => ModelDb.CardPool<PokemonCardPool>();
    public override RelicPoolModel RelicPool => ModelDb.RelicPool<PokemonRelicPool>();
    public override PotionPoolModel PotionPool => ModelDb.PotionPool<PokemonPotionPool>();

    // Starting deck
    public override IEnumerable<CardModel> StartingDeck => [
        ModelDb.Card<StrikePokemon>(),
        ModelDb.Card<StrikePokemon>(),
        ModelDb.Card<StrikePokemon>(),
        ModelDb.Card<StrikePokemon>(),
        ModelDb.Card<StrikePokemon>(),
    ];

    // Starting relics
    public override IReadOnlyList<RelicModel> StartingRelics => [
        // ModelDb.Relic<TestRelic>(),
    ];

    // Architect attack VFX list
    public override List<string> GetArchitectAttackVfx() => [
        "vfx/vfx_attack_blunt",
        "vfx/vfx_heavy_blunt",
        "vfx/vfx_attack_slash",
        "vfx/vfx_bloody_impact",
        "vfx/vfx_rock_shatter"
    ];
}