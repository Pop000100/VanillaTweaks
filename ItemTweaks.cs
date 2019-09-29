﻿
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.UI;

namespace VanillaTweaks
{
	public class ItemTweaks : GlobalItem
	{
		const string GladiatorSet = "miscellania_gladiator";
		const string ObsidianSet = "miscellania_obsidian";
		const string SWATSet = "miscellania_swat";
		const string EskimoSet = "miscellania_eskimo";
		const string CactusSet = "miscellania_cactus";
		const string VikingSet = "miscellania_viking";
		const string PharaohSet = "miscellania_pharaoh";
		
		public override void SetDefaults(Item item)
		{
			switch(item.type)
			{
				case ItemID.MeteorHamaxe:
					if(ServerConfig.Instance.HammerTweaks)
					{
						item.hammer = 50;
						item.axe = 70 / 5;
					}
					return;
				case ItemID.MoltenHamaxe:
					if(ServerConfig.Instance.HammerTweaks)
						item.axe = 80 / 5;
					return;
				case ItemID.TheBreaker:
				case ItemID.FleshGrinder:
					if(ServerConfig.Instance.HammerTweaks)
						item.hammer = 65;
					return;
				case ItemID.GladiatorHelmet:
					if(ServerConfig.Instance.GladiatorArmorTweak)
					{
						item.rare = 1;
						item.defense = 5;
					}
					return;
				case ItemID.GladiatorBreastplate:
					if(ServerConfig.Instance.GladiatorArmorTweak)
					{
						item.rare = 1;
						item.defense = 6;
					}
					return;
				case ItemID.GladiatorLeggings:
					if(ServerConfig.Instance.GladiatorArmorTweak)
					{
						item.rare = 1;
						item.defense = 5;
					}
					return;
				case ItemID.ObsidianHelm:
				case ItemID.ObsidianShirt:
				case ItemID.ObsidianPants:
					if(ServerConfig.Instance.ObsidianArmorTweak)
						item.rare = 1;
					return;
				case ItemID.MeteorHelmet:
				case ItemID.MeteorLeggings:
					if(ServerConfig.Instance.MeteorArmorDefenseTweak)
						item.defense = 4;
					return;
				case ItemID.MeteorSuit:
					if(ServerConfig.Instance.MeteorArmorDefenseTweak)
						item.defense = 5;
					return;
				case ItemID.EskimoHood:
				case ItemID.EskimoPants:
				case ItemID.PinkEskimoHood:
				case ItemID.PinkEskimoPants:
					if(ServerConfig.Instance.EskimoArmorTweak)
					{
						item.defense = 3;
						item.rare = 1;
					}
					return;
				case ItemID.EskimoCoat:
				case ItemID.PinkEskimoCoat:
					if(ServerConfig.Instance.EskimoArmorTweak)
					{
						item.defense = 4;
						item.rare = 1;
					}
					return;
				case ItemID.CactusLeggings:
				case ItemID.CactusHelmet:
					if(ServerConfig.Instance.CactusArmorTweak)
						item.defense = 1;
					return;
				case ItemID.CactusBreastplate:
					if(ServerConfig.Instance.CactusArmorTweak)
						item.defense = 2;
					return;
				case ItemID.PharaohsMask:
					if(ServerConfig.Instance.PharaohSetTweak)
					{
						item.vanity = false;
						item.defense = 3;
					}
					return;
				case ItemID.PharaohsRobe:
					if(ServerConfig.Instance.PharaohSetTweak)
					{
						item.vanity = false;
						item.defense = 4;
					}
					return;
				case ItemID.NightsEdge:
					if(ClientConfig.Instance.NightsEdgeAutoswing)
						item.autoReuse = true;
					return;
				case ItemID.TrueExcalibur:
				case ItemID.TrueNightsEdge:
					if(ClientConfig.Instance.TrueSwordsAutoswing)
						item.autoReuse = true;
					return;
				case ItemID.SWATHelmet:
					if(ServerConfig.Instance.SwatHelmetTweak)
					{
						item.vanity = false;
						item.rare = 8;
						item.defense = 17;
					}
					return;
//				case ItemID.Skull:
//					if(ServerConfig.Instance.SkullTweak)
//					{
//						item.vanity = false;
//						item.defense = 3;
//					}
//					return;
				case ItemID.FishBowl:
					if(ServerConfig.Instance.FishBowlTweak)
					{
						item.vanity = false;
						item.defense = 1;
					}
					return;
				case ItemID.WhoopieCushion:
					if(ServerConfig.Instance.EasterEgg)
					{
						item.useTime = 5;
						item.useAnimation = 5;
						item.reuseDelay = 0;
						item.autoReuse = true;
					}
					return;
				case ItemID.RainHat:
				case ItemID.RainCoat:
					if(ServerConfig.Instance.RainArmorTweak)
					{
						item.vanity = true;
						item.defense = 0;
					}
					return;
			}
		}
		
		public override void UpdateEquip(Item item, Player player)
		{
			switch(item.type)
			{
				case ItemID.ObsidianHelm:
				case ItemID.ObsidianShirt:
				case ItemID.ObsidianPants:
					if(ServerConfig.Instance.ObsidianArmorTweak)
						player.rangedCrit += 3;
					return;
				case ItemID.MeteorHelmet:
				case ItemID.MeteorSuit:
				case ItemID.MeteorLeggings:
					if(ServerConfig.Instance.MeteorArmorDamageTweak)
						player.magicDamage -= 0.07f;
					return;
				case ItemID.SWATHelmet:
					if(ServerConfig.Instance.SwatHelmetTweak)
					{
						player.rangedCrit += 10;
						player.rangedDamage += 0.15f;
					}
					return;
				case ItemID.EskimoHood:
				case ItemID.EskimoCoat:
				case ItemID.EskimoPants:
				case ItemID.PinkEskimoHood:
				case ItemID.PinkEskimoCoat:
				case ItemID.PinkEskimoPants:
					if(ServerConfig.Instance.EskimoArmorTweak)
						player.arcticDivingGear = true;
					return;
				case ItemID.PharaohsMask:
				case ItemID.PharaohsRobe:
					if(ServerConfig.Instance.PharaohSetTweak)
						player.minionDamage += 0.05f;
					return;
				case ItemID.CrimsonHelmet:
				case ItemID.CrimsonScalemail:
				case ItemID.CrimsonGreaves:
					if(ServerConfig.Instance.CrimsonArmorTweak)
					{
						player.meleeDamage += 0.02f;
						player.magicDamage -= 0.02f;
						player.rangedDamage -= 0.02f;
						player.minionDamage -= 0.02f;
						player.thrownDamage -= 0.02f;
					}
					return;
			}
		}
		
		public override string IsArmorSet(Item head, Item body, Item legs)
		{
			if(head.type == ItemID.GladiatorHelmet && body.type == ItemID.GladiatorBreastplate && legs.type == ItemID.GladiatorLeggings)
				return GladiatorSet;
			
			if(head.type == ItemID.ObsidianHelm && body.type == ItemID.ObsidianShirt && legs.type == ItemID.ObsidianPants)
				return ObsidianSet;
			
			if(head.type == ItemID.SWATHelmet && VanillaTweaks.MiscellaniaLoaded)
			{
				int reinforcedVest = ModLoader.GetMod("GoldensMisc").ItemType("ReinforcedVest");
				if(reinforcedVest > 0 && body.type == reinforcedVest)
					return SWATSet;
			}
			
			if((head.type == ItemID.EskimoHood || head.type == ItemID.PinkEskimoHood) &&
			   (body.type == ItemID.EskimoCoat || body.type == ItemID.PinkEskimoCoat) &&
			   (legs.type == ItemID.EskimoPants || legs.type == ItemID.PinkEskimoPants))
				return EskimoSet;
			
			if(head.type == ItemID.CactusHelmet && body.type == ItemID.CactusBreastplate && legs.type == ItemID.CactusLeggings)
				return CactusSet;
			
			if(head.type == ItemID.VikingHelmet &&
			  (body.type == ItemID.IronChainmail || body.type == ItemID.LeadChainmail) &&
			  (legs.type == ItemID.IronGreaves || legs.type == ItemID.LeadGreaves))
				return VikingSet;
			
			if(head.type == ItemID.PharaohsMask && body.type == ItemID.PharaohsRobe)
				return PharaohSet;

			return base.IsArmorSet(head, body, legs);
		}
		
		public override void UpdateArmorSet(Player player, string armorSet)
		{
			if(armorSet == GladiatorSet && ServerConfig.Instance.GladiatorArmorTweak)
			{
				player.setBonus = Language.GetTextValue("Mods.VanillaTweaks.ArmorSet.Gladiator");
				player.meleeCrit += 15;
				player.rangedCrit += 15;
				player.magicCrit += 15;
				player.thrownCrit += 15;
			}
			else if(armorSet == ObsidianSet && ServerConfig.Instance.ObsidianArmorTweak)
			{
				player.setBonus = Language.GetTextValue("Mods.VanillaTweaks.ArmorSet.Obsidian");
				player.moveSpeed += 0.1f;
			}
			else if(armorSet == SWATSet && ServerConfig.Instance.SwatHelmetTweak)
			{
				player.setBonus = Language.GetTextValue("Mods.VanillaTweaks.ArmorSet.Swat");
				player.endurance += 0.25f;
				player.rangedDamage += 0.2f;
				player.ammoCost80 = true;
			}
			else if(armorSet == EskimoSet && ServerConfig.Instance.EskimoArmorTweak)
			{
				player.setBonus = Language.GetTextValue("Mods.VanillaTweaks.ArmorSet.Eskimo");
				player.statDefense += 4;
				player.resistCold = true;
				player.buffImmune[BuffID.Chilled] = true;
				player.buffImmune[BuffID.Frozen] = true;
				player.buffImmune[BuffID.Frostburn] = true;
			}
			else if(armorSet == CactusSet && ServerConfig.Instance.CactusArmorTweak)
			{
				player.setBonus = Language.GetTextValue("Mods.VanillaTweaks.ArmorSet.Cactus");
				player.thorns += 0.25f;
				player.statDefense--;
			}
			else if(armorSet == VikingSet && ServerConfig.Instance.VikingHelmetTweak)
			{
				player.setBonus = Language.GetTextValue("Mods.VanillaTweaks.ArmorSet.Viking");
				player.rangedDamage += 0.05f;
				player.meleeDamage += 0.05f;
				player.thrownDamage += 0.05f;
				player.minionDamage += 0.05f;
				player.magicDamage += 0.05f;
			}
			else if(armorSet == PharaohSet && ServerConfig.Instance.PharaohSetTweak)
			{
				player.setBonus = Language.GetTextValue("Mods.VanillaTweaks.ArmorSet.Pharaoh");
				player.maxMinions++;
			}
		}
		
		public override void ArmorSetShadows(Player player, string armorSet)
		{
			if(armorSet == ObsidianSet && ServerConfig.Instance.ObsidianArmorTweak)
				player.armorEffectDrawShadow = true;
		}
		
		public override bool PreDrawInInventory(Item item, SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
		{
			if(ShouldFlip(item))
			{
				spriteBatch.Draw(Main.itemTexture[item.type], position, null, drawColor, 0f, origin, scale, SpriteEffects.FlipHorizontally, 0f);
				return false;
			}
			return true;
		}
		
		public override bool PreDrawInWorld(Item item, SpriteBatch spriteBatch, Color lightColor, Color alphaColor, ref float rotation, ref float scale, int whoAmI)
		{
			if(ShouldFlip(item))
			{
				spriteBatch.Draw(Main.itemTexture[item.type], item.position - Main.screenPosition, null, lightColor.MultiplyRGB(alphaColor), rotation, Vector2.Zero, scale, SpriteEffects.FlipHorizontally, 0f);
				return false;
			}
			return true;
		}
		
		static bool ShouldFlip(Item item)
		{
			bool skull = item.type == ItemID.Skull && ClientConfig.Instance.SkullTweak;
			bool joke = DateTime.Now.Month == 4 && DateTime.Now.Day == 1;
			return (skull || joke) && !(skull && joke);
		}
		
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if(ClientConfig.Instance.FavoriteTooltipRemove)
				tooltips.RemoveAll(line => line.mod == "Terraria" && line.Name.StartsWith("Favorite"));
			switch(item.type)
			{
				case ItemID.EskimoHood:
				case ItemID.EskimoCoat:
				case ItemID.EskimoPants:
				case ItemID.PinkEskimoHood:
				case ItemID.PinkEskimoCoat:
				case ItemID.PinkEskimoPants:
					if(ServerConfig.Instance.EskimoArmorTweak && !Main.expertMode)
						tooltips.RemoveAll(line => line.mod == "Terraria" && line.Name.StartsWith("Tooltip"));
					return;
			}
		}
	}
}
