/**
 * Конкретная Фабрика производит семейство продуктов одной вариации. Фабрика
 * гарантирует совместимость полученных продуктов. Обратите внимание, что
 * сигнатуры методов Конкретной Фабрики возвращают абстрактный продукт, в то
 * время как внутри метода создается экземпляр конкретного продукта.
 */
var ConcreteFactory1 = /** @class */ (function () {
    function ConcreteFactory1() {
    }
    ConcreteFactory1.prototype.createProductA = function () {
        return new ConcreteProductA1();
    };
    ConcreteFactory1.prototype.createProductB = function () {
        return new ConcreteProductB1();
    };
    return ConcreteFactory1;
}());
/**
 * Каждая Конкретная Фабрика имеет соответствующую вариацию продукта.
 */
var ConcreteFactory2 = /** @class */ (function () {
    function ConcreteFactory2() {
    }
    ConcreteFactory2.prototype.createProductA = function () {
        return new ConcreteProductA2();
    };
    ConcreteFactory2.prototype.createProductB = function () {
        return new ConcreteProductB2();
    };
    return ConcreteFactory2;
}());
/**
 * Конкретные продукты создаются соответствующими Конкретными Фабриками.
 */
var ConcreteProductA1 = /** @class */ (function () {
    function ConcreteProductA1() {
    }
    ConcreteProductA1.prototype.usefulFunctionA = function () {
        return 'The result of the product A1.';
    };
    return ConcreteProductA1;
}());
var ConcreteProductA2 = /** @class */ (function () {
    function ConcreteProductA2() {
    }
    ConcreteProductA2.prototype.usefulFunctionA = function () {
        return 'The result of the product A2.';
    };
    return ConcreteProductA2;
}());
/**
 * Конкретные Продукты создаются соответствующими Конкретными Фабриками.
 */
var ConcreteProductB1 = /** @class */ (function () {
    function ConcreteProductB1() {
    }
    ConcreteProductB1.prototype.usefulFunctionB = function () {
        return 'The result of the product B1.';
    };
    /**
     * Продукт B1 может корректно работать только с Продуктом A1. Тем не менее,
     * он принимает любой экземпляр Абстрактного Продукта А в качестве
     * аргумента.
     */
    ConcreteProductB1.prototype.anotherUsefulFunctionB = function (collaborator) {
        var result = collaborator.usefulFunctionA();
        return "The result of the B1 collaborating with the (" + result + ")";
    };
    return ConcreteProductB1;
}());
var ConcreteProductB2 = /** @class */ (function () {
    function ConcreteProductB2() {
    }
    ConcreteProductB2.prototype.usefulFunctionB = function () {
        return 'The result of the product B2.';
    };
    /**
     * Продукт B2 может корректно работать только с Продуктом A2. Тем не менее,
     * он принимает любой экземпляр Абстрактного Продукта А в качестве
     * аргумента.
     */
    ConcreteProductB2.prototype.anotherUsefulFunctionB = function (collaborator) {
        var result = collaborator.usefulFunctionA();
        return "The result of the B2 collaborating with the (" + result + ")";
    };
    return ConcreteProductB2;
}());
/**
 * Клиентский код работает с фабриками и продуктами только через абстрактные
 * типы: Абстрактная Фабрика и Абстрактный Продукт. Это позволяет передавать
 * любой подкласс фабрики или продукта клиентскому коду, не нарушая его.
 */
function clientCodeAbstructFactory(factory) {
    var productA = factory.createProductA();
    var productB = factory.createProductB();
    console.log(productB.usefulFunctionB());
    console.log(productB.anotherUsefulFunctionB(productA));
}
/**
 * Клиентский код может работать с любым конкретным классом фабрики.
 */
console.log('Client: Testing client code with the first factory type...');
clientCodeAbstructFactory(new ConcreteFactory1());
console.log('');
console.log('Client: Testing the same client code with the second factory type...');
clientCodeAbstructFactory(new ConcreteFactory2());
//# sourceMappingURL=abstructFucktory.js.map