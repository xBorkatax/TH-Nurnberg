add $t0,$a0,$zero # $t0 = $a0 + $0 = $a0; einfacher Weg, einen Wert zu kopieren
add $t1,$a1,$zero # $t1 = $a1
addi $t2,$zero,12 # $t2 = $0+12 = 0+12
mult $t1,$t2	  # (hi,lo) = $t1 · $t2	 
mflo $t1	  # $t1 = lo; wir gehen davon aus, dass das Ergebnis in lo reinpasst	
sub $t0,$t0,$t1	  # $t0 = $t0-$t1
addi $t0,$t0,-10  # $t0 = $t0-10; statt 10 abzuziehen, addieren wir -10
addi $t2,$zero,5  # $t2 = 5
div $t0,$t2	  # lo = $t0/$t2	
mflo $v0	  # ergebnis