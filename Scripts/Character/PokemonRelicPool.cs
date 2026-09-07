using BaseLib.Abstracts;
using Godot;

namespace Pokemon.Pokemon.Character;

public class PokemonRelicPool : CustomRelicPoolModel
{
    // Energy icon for descriptions. 24×24.
    public override string? TextEnergyIconPath => "res://Pokemon/images/energy.png";
    // Energy icon for tooltips and card corner. 74×74.
    public override string? BigEnergyIconPath => "res://Pokemon/images/energy_big.png";
}