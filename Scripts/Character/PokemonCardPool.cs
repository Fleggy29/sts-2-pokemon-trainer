using BaseLib.Abstracts;
using Godot;

namespace Pokemon.Pokemon.Character;
public class PokemonCardPool : CustomCardPoolModel
{
    // Pool ID. Must be unique.
    public override string Title => "Pokemon";

    // Energy icon for descriptions. 24×24.
    public override string? TextEnergyIconPath => "res://Pokemon/images/energy.png";
    // Energy icon for tooltips and card corner. 74×74.
    public override string? BigEnergyIconPath => "res://Pokemon/images/energy_big.png";

    // Pool accent color.
    public override Color DeckEntryCardColor => new(0.5f, 0.5f, 1f);

    // If using the default card frame, this color tints it.
    public override Color ShaderColor => new(0.5f, 0.5f, 1f);

    // If using a custom card frame, override CustomFrame and return your frame image.
    // public override Texture2D? CustomFrame(CustomCardModel card)
    // {
    //     return card.Type switch
    //     {
    //         CardType.Attack => PreloadManager.Cache.GetAsset<Texture2D>("res://test/images/card_frame_attack.png"),
    //         CardType.Power => PreloadManager.Cache.GetAsset<Texture2D>("res://test/images/card_frame_power.png"),
    //         _ => PreloadManager.Cache.GetAsset<Texture2D>("res://test/images/card_frame_skill.png"),
    //     };
    // }

    // Whether the pool is colorless. Events, statuses, etc. are colorless.
    public override bool IsColorless => false;
}