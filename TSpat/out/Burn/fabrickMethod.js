var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
/**
 * Класс Создатель объявляет фабричный метод, который должен возвращать объект
 * класса Продукт. Подклассы Создателя обычно предоставляют реализацию этого
 * метода.
 */
var Creator = /** @class */ (function () {
    function Creator() {
    }
    /**
     * Также заметьте, что, несмотря на название, основная обязанность Создателя
     * не заключается в создании продуктов. Обычно он содержит некоторую базовую
     * бизнес-логику, которая основана на объектах Продуктов, возвращаемых
     * фабричным методом. Подклассы могут косвенно изменять эту бизнес-логику,
     * переопределяя фабричный метод и возвращая из него другой тип продукта.
     */
    Creator.prototype.someOperation = function () {
        // Вызываем фабричный метод, чтобы получить объект-продукт.
        var product = this.factoryMethod();
        // Далее, работаем с этим продуктом.
        return "Creator: The same creator's code has just worked with " + product.operation();
    };
    return Creator;
}());
/**
 * Конкретные Создатели переопределяют фабричный метод для того, чтобы изменить
 * тип результирующего продукта.
 */
var ConcreteCreator1 = /** @class */ (function (_super) {
    __extends(ConcreteCreator1, _super);
    function ConcreteCreator1() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    /**
     * Обратите внимание, что сигнатура метода по-прежнему использует тип
     * абстрактного продукта, хотя фактически из метода возвращается конкретный
     * продукт. Таким образом, Создатель может оставаться независимым от
     * конкретных классов продуктов.
     */
    ConcreteCreator1.prototype.factoryMethod = function () {
        return new ConcreteProduct1();
    };
    return ConcreteCreator1;
}(Creator));
var ConcreteCreator2 = /** @class */ (function (_super) {
    __extends(ConcreteCreator2, _super);
    function ConcreteCreator2() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    ConcreteCreator2.prototype.factoryMethod = function () {
        return new ConcreteProduct2();
    };
    return ConcreteCreator2;
}(Creator));
/**
 * Конкретные Продукты предоставляют различные реализации интерфейса Продукта.
 */
var ConcreteProduct1 = /** @class */ (function () {
    function ConcreteProduct1() {
    }
    ConcreteProduct1.prototype.operation = function () {
        return '{Result of the ConcreteProduct1}';
    };
    return ConcreteProduct1;
}());
var ConcreteProduct2 = /** @class */ (function () {
    function ConcreteProduct2() {
    }
    ConcreteProduct2.prototype.operation = function () {
        return '{Result of the ConcreteProduct2}';
    };
    return ConcreteProduct2;
}());
/**
 * Клиентский код работает с экземпляром конкретного создателя, хотя и через его
 * базовый интерфейс. Пока клиент продолжает работать с создателем через базовый
 * интерфейс, вы можете передать ему любой подкласс создателя.
 */
function clientCodeFactoryMethod(creator) {
    // ...
    console.log('Client: I\'m not aware of the creator\'s class, but it still works.');
    console.log(creator.someOperation());
    // ...
}
/**
 * Приложение выбирает тип создателя в зависимости от конфигурации или среды.
 */
console.log('App: Launched with the ConcreteCreator1.');
clientCodeFactoryMethod(new ConcreteCreator1());
console.log('');
console.log('App: Launched with the ConcreteCreator2.');
clientCodeFactoryMethod(new ConcreteCreator2());
//# sourceMappingURL=fabrickMethod.js.map