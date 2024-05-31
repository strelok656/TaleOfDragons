using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Test.Content.Projectiles {
    public class Projectile1 : ModProjectile {
        public override void SetDefaults() {
            Projectile.DamageType = DamageClass.Melee; //Тип урона
            Projectile.scale = 2f; //Мультипликатор размера
            Projectile.penetrate = 3; // Сколько целей пронзит снаряд перед исчезновением 
            Projectile.aiStyle = 0; // ИИ снаряда. 0 это ии пули
            Projectile.width = 15; // Ширина спрайта
            Projectile.height = 15;// Высота спрайта
            Projectile.friendly = true; //Бьет ли врагов?
            Projectile.hostile = false; // Бьет ли игрока?
            Projectile.timeLeft = 180; // Кол-во оставшегося времени перед исчезновением снаряда
            Projectile.light = 0.3f; // Кол-во излучаемого света
            Projectile.ignoreWater = true; // Игнорирует воду
            Projectile.tileCollide = false; // Не соприкасается с блоками
            Projectile.alpha = 50; //Прозрачность
            Projectile.Center = new Vector2(3f, -2f);

            
        }
    }
}