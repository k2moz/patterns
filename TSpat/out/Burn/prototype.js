var __assign = (this && this.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};
/**
 * Пример класса, имеющего возможность клонирования. Мы посмотрим как происходит
 * клонирование значений полей разных типов.
 */
var Prototype = /** @class */ (function () {
    function Prototype() {
    }
    Prototype.prototype.clone = function () {
        var clone = Object.create(this);
        clone.component = Object.create(this.component);
        // Клонирование объекта, который имеет вложенный объект с обратной
        // ссылкой, требует специального подхода. После завершения клонирования
        // вложенный объект должен указывать на клонированный объект, а не на
        // исходный объект. Для данного случая хорошо подойдёт оператор
        // расширения (spread).
        clone.circularReference = __assign(__assign({}, this.circularReference), { prototype: __assign({}, this) });
        return clone;
    };
    return Prototype;
}());
var ComponentWithBackReference = /** @class */ (function () {
    function ComponentWithBackReference(prototype) {
        this.prototype = prototype;
    }
    return ComponentWithBackReference;
}());
/**
 * Клиентский код.
 */
function clientCodePrototype() {
    var p1 = new Prototype();
    p1.primitive = 245;
    p1.component = new Date();
    p1.circularReference = new ComponentWithBackReference(p1);
    var p2 = p1.clone();
    if (p1.primitive === p2.primitive) {
        console.log('Primitive field values have been carried over to a clone. Yay!');
    }
    else {
        console.log('Primitive field values have not been copied. Booo!');
    }
    if (p1.component === p2.component) {
        console.log('Simple component has not been cloned. Booo!');
    }
    else {
        console.log('Simple component has been cloned. Yay!');
    }
    if (p1.circularReference === p2.circularReference) {
        console.log('Component with back reference has not been cloned. Booo!');
    }
    else {
        console.log('Component with back reference has been cloned. Yay!');
    }
    if (p1.circularReference.prototype === p2.circularReference.prototype) {
        console.log('Component with back reference is linked to original object. Booo!');
    }
    else {
        console.log('Component with back reference is linked to the clone. Yay!');
    }
}
clientCodePrototype();
//# sourceMappingURL=prototype.js.map