    li  $a0,2
    jal primtest
 ende: b ende

primtest:        
        move $v0,$zero            # Vorgabe: Ergebnis = 0 (nicht prim)
        li   $t1,1                # Test auf 1
        slt  $t2,$t1,$a0          # muss größer sein
        beq  $t2,$zero,fertig     # sonst nicht prim (also 1, 0, negative Zahlen)
        li   $t1,4                # Test, ob 2 oder 3
        slt  $t2,$a0,$t1          # 
        bne  $t2,$zero,prim       # Dann prim
        andi $t1,$a0,0x0001       # Wir testen die Teilbarkeit durch 2
        beq  $t1,$zero,fertig     # wenn teilbar, nicht prim
        li   $t0,3                # und machen mit 3, 5, 7, ... weiter
schleife:
        div  $a0,$t0
        mflo $t1
        slt  $t2,$t1,$t0          # Wenn der Quotient kleiner ist als der Divisor
        bne  $t2,$zero,prim       # dann sind wir über der Wurzel
        mfhi $t1                  # Vergleich den Rest auf 0
        beq  $t1,$zero,fertig     # Wenn ja, dann ist sie nicht prim
        addi $t0,$t0,2
        b    schleife             # Sonst weiter suchen
prim:
        li   $v0,1                # Setze Ergebnis auf 1 (prim)
fertig:
        jr  $ra