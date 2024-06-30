[METANIT](https://metanit.com/sharp/razorpages/3.1.php)

- Можно описывать отдельные секции:
	1. Добавить в `_Layout.cshtml`:
	``` html
	...
	<body>
		...
		<footer>@RenderSection("Footer")</footer>
	</body>
	```

	2. Добавить в `Index.cshtml`:
	``` html
	...
	@section Footer {
		Copyright (c) 2022
	}
	```
	
	и т.д. во всех страницах

- Можно задать значение по умолчанию:
	В `_Layout.cshtml`:
	``` html
	...
	<body>
		...
		<!-- Если не задано - не отображать ничего -->
		<footer>@RenderSection("Footer", false)</footer>
	</body>
	```

	или:
	``` html
	...
	<body>
		...
		<footer>
			@if (IsSectionDefined("Footer")) {
				@RenderSection("Footer")
			} else {
				<span>Содержание элемента footer по умолчанию.</span>
			}
</footer>
	</body>
	```
