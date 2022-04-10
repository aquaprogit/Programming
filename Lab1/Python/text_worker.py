def second_without_first(first: list[str], second: list[str]) -> list[str]:
    return [i for i in second if i not in first]
def get_content_length(content: list[str]) -> int:
    return len(content)