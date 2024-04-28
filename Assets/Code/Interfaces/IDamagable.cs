using System;
using System.Collections.Generic;
using System.Text;

public interface IDamagable { 
    float hp { get; set; }
    float armor { get; set; }

    void TakeDamage(float damage) { }

}
