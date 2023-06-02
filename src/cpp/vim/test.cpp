#include <iostream>
#include "object-model.h"

template<typename T>
void test(std::string message, T actual, T expected)
{
    if (actual != expected)
        std::cout << message << std::endl
                  << "Expected: " << expected << ". Actual: " << actual << std::endl;

    assert(actual == expected);
}

template<typename T>
void test(std::string message, const std::vector<T>& actual, const std::vector<T>& expected)
{
    assert(actual.size() == expected.size());

    for (int i = 0; i < actual.size(); ++i)
    {
        if (actual[i] != expected[i])
            std::cout << message << std::endl
                      << "Expected[" << i << "]: " << expected[i]
                      << ". Actual[" << i << "]: " << actual[i] << std::endl;

        assert(actual[i] == expected[i]);
    }
}

void test_element(const Vim::DocumentModel& model, const size_t expected_element_count)
{
    assert(model.mElement);

    test("Element count", model.mElement->GetCount(), expected_element_count);
    test("Element 0 ID", model.mElement->GetId(0), -1ll);
    test("Element 1 ID", model.mElement->GetId(1), 1222722ll);
    test("Element 2 ID", model.mElement->GetId(2), 32440ll);
    test("Element 3 ID", model.mElement->GetId(3), 118390ll);

    // TODO: improve expected test definition on a per-element basis
    test("Element 30 Index", model.mElement->Get(30)->mIndex, 30);
    test("Element 30 ID", model.mElement->Get(30)->mId, 374011ll);
    test("Element 30 Name", *model.mElement->Get(30)->mName, std::string("GWB on Mtl. Stud"));
    test("Element 30 UniqueID", *model.mElement->Get(30)->mUniqueId, std::string("3ae43fb5-6797-479b-ac14-3436f35a7178-0005b4fb"));
    test("Element 30 FamilyNome", *model.mElement->Get(30)->mFamilyName, std::string("Compound Ceiling"));
    test("Element 30 IsPinned", model.mElement->Get(30)->mIsPinned, false);
    test("Element 30 LevelIndex", model.mElement->Get(30)->mLevelIndex, 6);
    test("Element 30 PhaseCreatedIndex", model.mElement->Get(30)->mPhaseCreatedIndex, 1);
    test("Element 30 PhaseDemolishedIndex", model.mElement->Get(30)->mPhaseDemolishedIndex, -1);
    test("Element 30 CategoryIndex", model.mElement->Get(30)->mCategoryIndex, 5);
    test("Element 30 WorksetIndex", model.mElement->Get(30)->mWorksetIndex, 0);
    test("Element 30 DesignOptionIndex", model.mElement->Get(30)->mDesignOptionIndex, -1);
    test("Element 30 OwnerViewIndex", model.mElement->Get(30)->mOwnerViewIndex, -1);
    test("Element 30 GroupIndex", model.mElement->Get(30)->mGroupIndex, -1);
    test("Element 30 AssemblyInstanceIndex", model.mElement->Get(30)->mAssemblyInstanceIndex, -1);
    test("Element 30 BimDocumentIndex", model.mElement->Get(30)->mBimDocumentIndex, 0);
    test("Element 30 RoomIndex", model.mElement->Get(30)->mRoomIndex, -1);
    test("Element 30 RoomIndex", model.mElement->Get(30)->mLocation_X, 0.0f);
    test("Element 30 RoomIndex", model.mElement->Get(30)->mLocation_Y, 0.0f);
    test("Element 30 RoomIndex", model.mElement->Get(30)->mLocation_Z, 0.0f);

    std::cout << "Get element test: OK" << std::endl;
}

void test_element_ids(const Vim::DocumentModel& model)
{
    assert(model.mElement);

    auto ids = model.mElement->GetAllId();

    std::vector<long long> expectedIds = { -1ll, 1222722ll, 32440ll, 118390ll, 174750ll, 18438ll, 355500ll, 185913ll, 9946ll, 182664ll };
    std::vector<long long> actualIds = *ids;
    actualIds.resize(10);

    test("Element IDs count", (int) ids->size(), 4464);
    test("Element IDs", actualIds, expectedIds);

    std::cout << "Get element IDs test: OK" << std::endl;
}

void test_get_all(const Vim::DocumentModel& model)
{
    assert(model.mLevel);

    auto levels = model.mLevel->GetAll();

    test("Levels count", (int) levels->size(), 12);

    std::cout << "Get-all test: OK" << std::endl;
}

constexpr char pathSeparator =
#if defined(__ANDROID__) || defined(__APPLE__)
    '/';
#else
    '\\';
#endif

std::string normalizePath(const std::string& fileName)
{
    std::string ret = fileName;

#if defined(__ANDROID__) || defined(__APPLE__)
    std::replace(ret.begin(), ret.end(), '\\', platformPathSeparator);
#else
    std::replace(ret.begin(), ret.end(), '/', pathSeparator);
#endif

    return ret;
}

int test_wolford(const std::string& vim_file_path, const int expected_element_count)
{
    std::cout << "Testing VIM file: " << vim_file_path << std::endl;

    Vim::VimScene scene;
    scene.ReadFile(vim_file_path);

    const Vim::DocumentModel model(scene);

    test_element(model, expected_element_count);
    test_element_ids(model);
    test_get_all(model);

    return 0;
}

int main(int num, char** args)
{
    auto this_exe_path = normalizePath(std::string(args[0]));
    
    const auto this_dir = this_exe_path.erase(this_exe_path.rfind("src"));

    const std::vector<std::tuple<std::string, int>> tests =
    {
        //std::tuple<std::string, int>(normalizePath("data\\Wolford_Residence.r2023.om_v4.4.0.vim"), 4464), // TODO: restore this
        std::tuple<std::string, int>(normalizePath("data\\Wolford_Residence.r2023.om_v5.0.0.vim"), 4473),
    };
    for (const auto& test : tests)
    {
        const auto vim_file_path = this_dir + std::get<0>(test);
        const auto expected_element_count = std::get<1>(test);
        const auto result = test_wolford(vim_file_path, expected_element_count);
        if (result != 0)
            return result;
    }

    return 0;
}