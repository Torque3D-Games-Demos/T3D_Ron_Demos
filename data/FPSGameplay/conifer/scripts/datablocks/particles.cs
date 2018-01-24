
datablock ParticleData(ParticleMist)
{
   textureName = "data/FPSGameplay/conifer/art/particles/sickieparticles/mist.png";
   dragCoeffiecient = 0;
   gravityCoefficient = "-0.0854701";
   inheritedVelFactor = 0;
   constantAcceleration = -1;
   lifetimeMS = 2500;
   lifetimeVarianceMS = 0;
   useInvAlpha = 0;
   spinRandomMin = -125;
   spinRandomMax = 125;
   spinSpeed = 0.520833;

   colors[0] = "0.992126 0.992126 0.992126 0.436";
   colors[1] = "0.992126 0.992126 0.992126 0.465";
   colors[2] = "0.992126 0.992126 0.992126 0.668";
   colors[3] = "0.992126 0.992126 0.992126 0.23622";
   
   sizes[0] = 2;
   sizes[1] = 8;
   sizes[2] = 9;
   sizes[3] = "10.5";
   
   times[0] = 0.0;
   times[1] = "0.4";
   times[2] = "0.5";
   times[3] = "0.6";
   
   animTexName = "data/FPSGameplay/conifer/art/particles/sickieparticles/mist.png";
   
   dragCoefficient = "0.889541";
};

datablock ParticleData(ParticleMainFalls01)
{
   textureName = "data/FPSGameplay/conifer/art/particles/sickieparticles/main falls 01.png";
   animTexName = "data/FPSGameplay/conifer/art/particles/sickieparticles/main falls 01.png";
   gravityCoefficient = "0.788767";
   sizes[0] = "5.20662";
   sizes[1] = "14.5822";
   constantAcceleration = "0.416666";
   sizes[2] = "10.4163";
   sizes[3] = "0";
   lifetimeMS = "3001";
   inheritedVelFactor = "0.41683";
   times[1] = "0.329412";
   times[2] = "0.658824";
   colors[0] = "0.235294 0.403922 0.345098 1";
   colors[1] = "0.807843 0.85098 0.87451 1";
};

datablock ParticleEmitterData(EmitterMist)
{
   particles = "ParticleMist";
   blendStyle = "NORMAL";
   ejectionVelocity = "5.11";
   velocityVariance = "0";
   thetaMax = "165";
   softParticles = "1";
   ambientFactor = "0.416667";
   ejectionPeriodMS = "167";
};

datablock ParticleEmitterData(EmitterMainFalls)
{
   particles = "ParticleMainFalls01";
   blendStyle = "NORMAL";
   ejectionVelocity = "3.5";
   velocityVariance = "0";
   thetaMax = "10";
   ejectionPeriodMS = "146";
   softnessDistance = "1";
   orientParticles = "1";
   softParticles = "1";
   lifetimeMS = "0";
   ambientFactor = "0";
};