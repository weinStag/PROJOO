5.3 [Challenge 8.4] Para cada classe abaixo, diga se aparenta
ser um Singleton e por que.

No ponto de vista de implementação, todas as classes são Singleton, exceto o PrinterManager que pode ser instanciado
mais de uma vez. Podemos justificar tal afirmação para as bibliotecas java uma vez que toda biblioteca é instanciada
pelo compiler da linguaguem uma só vez, para os demais "Printers" só teremos um Spooler e um Stream instanciado para
a biblioteca print por exemplo.