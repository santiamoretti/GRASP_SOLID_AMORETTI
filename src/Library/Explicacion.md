En mi implementacion, la interfaz IPrinter acepte una cadena de texto en lugar de un objeto Recipe. De esta manera, el método PrintRecipe simplemente imprime cualquier cadena que reciba, y no está directamente vinculado a la clase Recipe.

Pasos:

Modificar la interfaz IPrinter para que acepte una cadena de texto en PrintRecipe.

Actualizar ConsolePrinter y FilePrinter para usar la interfaz IPrinter modificada.

En la clase Program, en lugar de pasar el objeto Recipe al método PrintRecipe, pasar la cadena obtenida de recipe.GetTextToPrint().