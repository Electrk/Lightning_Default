datablock AudioProfile (ThunderCrash1Sound)
{
   filename    = "Add-Ons/Lightning_Default/thunder1.wav";
   description = Audio2d;
};

datablock AudioProfile (ThunderCrash2Sound)
{
   filename    = "Add-Ons/Lightning_Default/thunder2.wav";
   description = Audio2d;
};

datablock AudioProfile (ThunderCrash3Sound)
{
   filename    = "Add-Ons/Lightning_Default/thunder3.wav";
   description = Audio2d;
};

datablock AudioProfile (ThunderCrash4Sound)
{
   filename    = "Add-Ons/Lightning_Default/thunder4.wav";
   description = Audio2d;
};

datablock AudioProfile (LightningStrikeSound)
{
   filename    = "Add-Ons/Lightning_Default/lightningStrike.wav";
   description = AudioClosest3d;
};


datablock LightningData (LightningDefault)
{
   damageType = $DamageType::LightningStrike;

   strikeTextures[0] = "Add-Ons/Lightning_Default/lightning1frame1";
   strikeTextures[1] = "Add-Ons/Lightning_Default/lightning1frame2";
   strikeTextures[2] = "Add-Ons/Lightning_Default/lightning1frame3";
   
   strikeSound = LightningStrikeSound;

   thunderSounds[0] = ThunderCrash1Sound;
   thunderSounds[1] = ThunderCrash2Sound;
   thunderSounds[2] = ThunderCrash3Sound;
   thunderSounds[3] = ThunderCrash4Sound;
};
