  addi $t0,$zero,100
  add  $v0,$zero,$zero
schleife:
  add  $v0,$v0,$t0
  addi $t0,$t0,-1
  bne  $t0,$zero,schleife
  
