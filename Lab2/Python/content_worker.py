from furniture import Furniture


def select_available_types(furniture_list: list[Furniture], category: str, kind: str) -> list[Furniture]:
    return [furn for furn in furniture_list if furn.name == category and furn.kind == kind and furn.amount > 0]


def without_range(furniture_list: list[Furniture], min_value: int, max_value: int) -> list[Furniture]:
    return [furn for furn in furniture_list if min_value < furn.price > max_value ]
