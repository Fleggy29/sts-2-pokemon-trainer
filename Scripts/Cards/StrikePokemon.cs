using BaseLib.Abstracts;
using BaseLib.Utils;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Models.CardPools;
using MegaCrit.Sts2.Core.ValueProps;
using Pokemon.Pokemon.Character;

namespace Pokemon.Scripts.Cards;

/// <summary>
/// The only difference between the starting Strike cards are portrait, attack vfx, and color.
/// </summary>
// Register the card. For custom pools, see the Adding Characters introduction.
[Pool(typeof(PokemonCardPool))]
public class StrikePokemon : CustomCardModel
{
    // Base energy cost
    private const int energyCost = 1;
    // Card type
    private const CardType type = CardType.Attack;
    // Card rarity
    private const CardRarity rarity = CardRarity.Basic;
    // Target type (AnyEnemy means any enemy)
    private const TargetType targetType = TargetType.AnyEnemy;
    // Whether to show in the card library
    private const bool shouldShowInCardLibrary = true;

	protected override HashSet<CardTag> CanonicalTags => new HashSet<CardTag> { CardTag.Strike };

    // Base card values (e.g. 12 damage)
    protected override IEnumerable<DynamicVar> CanonicalVars => [new DamageVar(6, ValueProp.Move)];

	public override string PortraitPath => $"res://Pokemon/images/cards/{nameof(StrikePokemon)}.png";

    public StrikePokemon() : base(energyCost, type, rarity, targetType, shouldShowInCardLibrary)
    {
    }

    // Effect logic when played
    protected override async Task OnPlay(PlayerChoiceContext choiceContext, CardPlay cardPlay)
    {
        ArgumentNullException.ThrowIfNull(cardPlay.Target, "cardPlay.Target");
        await DamageCmd.Attack(DynamicVars.Damage.BaseValue) // Deal damage from the card's base damage value
            .FromCard(this, cardPlay) // Damage comes from this card
            // .FromCard(this) // stable version syntax
            .Targeting(cardPlay.Target) // Target is the player's selection
			.WithHitFx("vfx/vfx_attack_slash")
            .Execute(choiceContext);
    }

    // Upgrade effect logic
    protected override void OnUpgrade()
    {
        DynamicVars.Damage.UpgradeValueBy(3); // Increase damage by 4 on upgrade
    }
}