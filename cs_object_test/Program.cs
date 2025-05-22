using cs_object_test;

Player masaru = new Player("まさる");
masaru.ShowStatus();
masaru.SpecialAttack();

Player tuyoshi = new Warrior("つよし");
tuyoshi.ShowStatus();
((Warrior)tuyoshi).HardAttack();
tuyoshi.SpecialAttack();
