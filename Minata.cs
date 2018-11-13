using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HavenMod.NPCs
{
	public class Minata : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Minata");
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 14;
			npc.defense = 6;
			npc.lifeMax = 100;
			npc.value = 60f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 5;
			aiType = NPCID.Crimera;
			animationType = NPCID.Crimera;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDayMonster.Chance * 0.5f;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = Main.rand.Next(139, 143);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
	}
}
