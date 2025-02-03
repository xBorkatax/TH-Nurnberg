.data
X: .word 1024       # X = 1024
x: .word 4096       # x = 4096

.text
main:
    # Lade Adressen 
    la $t0, X 
    la $t1, x

    # Lade Werte 
    lw $s1, 0($t0)
    lw $s2, 0($t1)

    # Tausche die Werte
    sw $s1, 0($t1)
    sw $s2, 0($t0)    